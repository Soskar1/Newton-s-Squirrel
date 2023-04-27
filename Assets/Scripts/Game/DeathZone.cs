using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Obstacle>() != null)
            Destroy(collision.gameObject);
    }
}
