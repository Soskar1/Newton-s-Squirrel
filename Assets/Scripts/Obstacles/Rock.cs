public class Rock : Obstacle
{
    private IMovement _movement;

    private void Awake() => _movement = GetComponent<IMovement>();

    private void FixedUpdate() => _movement.Move();
}
