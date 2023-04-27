using UnityEngine;

public class Award : MonoBehaviour
{
    [SerializeField] private int _points;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponentInParent<Player>() != null)
        {
            Score.instance.GainPoints(_points);
            Destroy(gameObject);
        }
    }
}
