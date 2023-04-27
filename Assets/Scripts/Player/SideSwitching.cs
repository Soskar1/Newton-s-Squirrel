using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(GroundCheck))]
[RequireComponent(typeof(Gravity))]
public class SideSwitching : MonoBehaviour
{
    [SerializeField] private GroundCheck _groundCheck;
    [SerializeField] private Gravity _gravity;

    [SerializeField] private Transform _negativeSide;
    [SerializeField] private Transform _positiveSide;

    private int _currentLayer;

    public void TryToSwitchFromPositiveToNegative(InputAction.CallbackContext ctx)
    {
        if (_groundCheck.CheckForGround() && _currentLayer == 9) // 9 — Positive Layer
        {
            transform.position = _negativeSide.position;
            _gravity.Change();
        }
    }

    public void TryToSwitchFromNegativeToPositive(InputAction.CallbackContext ctx)
    {
        if (_groundCheck.CheckForGround() && _currentLayer == 8) // 8 — Negative Layer
        {
            transform.position = _positiveSide.position;
            _gravity.Change();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 ||
            collision.gameObject.layer == 9)
            _currentLayer = collision.gameObject.layer;
    }
}
