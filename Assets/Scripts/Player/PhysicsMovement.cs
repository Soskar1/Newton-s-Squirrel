using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsMovement : MonoBehaviour, IMovement
{
    [SerializeField] private Rigidbody2D _rb2d;
    [SerializeField] private float _speed;
    [Range(-1, 1)][SerializeField] private int _direction;

    public void Move() => _rb2d.velocity = new Vector2(_direction * _speed * Time.fixedDeltaTime, _rb2d.velocity.y);
}
