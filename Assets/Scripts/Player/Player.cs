using UnityEngine;

[RequireComponent(typeof(Gravity))]
[RequireComponent(typeof(SideSwitching))]
[RequireComponent(typeof(PlayerInput))]
public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;
    [SerializeField] private SideSwitching _sideSwitching;
    [SerializeField] private Gravity _gravity;
    private IMovement _movement;
    private IDying _death;

    private void Awake()
    {
        _movement = GetComponent<IMovement>();
        _death = GetComponent<IDying>();
    }

    private void Start()
    {
        _input._controls.Player.ChangeGravity.performed += _gravity.TryToChange;
        _input._controls.Player.FromNegativeToPositive.performed += _sideSwitching.TryToSwitchFromNegativeToPositive;
        _input._controls.Player.FromPositiveToNegative.performed += _sideSwitching.TryToSwitchFromPositiveToNegative;
    }

    private void FixedUpdate() => _movement.Move();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Obstacle>() != null)
        {
            _death.Die();
            _input._controls.Player.ChangeGravity.performed -= _gravity.TryToChange;
            _input._controls.Player.FromNegativeToPositive.performed -= _sideSwitching.TryToSwitchFromNegativeToPositive;
            _input._controls.Player.FromPositiveToNegative.performed -= _sideSwitching.TryToSwitchFromPositiveToNegative;
        }
    }
}
