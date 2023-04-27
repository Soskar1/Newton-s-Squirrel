using UnityEngine;

public class Flipping : MonoBehaviour
{
    public void Flip()
    {
        Vector3 size = transform.localScale;
        size.y *= -1;
        transform.localScale = size;
    }
}
