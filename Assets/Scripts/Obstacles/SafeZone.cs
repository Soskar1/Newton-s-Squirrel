using UnityEngine;

public class SafeZone : MonoBehaviour
{
    [SerializeField] private Transform _firstPoint;
    [SerializeField] private Transform _secondPoint;

    [SerializeField] private LayerMask _whatIsObstacle;

    private void Awake() => NeutralizeTheDanger(CheckForObstacles());

    private GameObject CheckForObstacles()
    {
        Collider2D _overlapInfo = Physics2D.OverlapArea(_firstPoint.position, _secondPoint.position, _whatIsObstacle);

        if (_overlapInfo != null)
            return _overlapInfo.gameObject;

        return null;
    }

    private void NeutralizeTheDanger(GameObject obstacle) => Destroy(obstacle);

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(_firstPoint.position, new Vector2(_secondPoint.position.x, _firstPoint.position.y));
        Gizmos.DrawLine(new Vector2(_secondPoint.position.x, _firstPoint.position.y), _secondPoint.position);
        Gizmos.DrawLine(_secondPoint.position, new Vector2(_firstPoint.position.x, _secondPoint.position.y));
        Gizmos.DrawLine(new Vector2(_firstPoint.position.x, _secondPoint.position.y), _firstPoint.position);
    }
}
