using UnityEngine;

public class Ground : MonoBehaviour
{
    public Transform endPosition;

    public void Replace(Transform newPosition)
    {
        transform.position = newPosition.position;
        transform.rotation = Quaternion.Euler(Vector3.zero);
        endPosition.gameObject.SetActive(true);
    }
}
