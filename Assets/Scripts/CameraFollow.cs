using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;

    public float speed = 5;

    public void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(playerTransform.position.x, playerTransform.position.y, -10) + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
