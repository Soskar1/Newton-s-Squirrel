using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Transform _teleportToPoint;

    private void TeleportEntityTo(Transform entity)
    {
        entity.position = _teleportToPoint.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponentInParent<Player>() != null)
            TeleportEntityTo(collision.transform.parent);
    }
}
