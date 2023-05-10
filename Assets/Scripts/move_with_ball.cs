using UnityEngine;

public class move_with_ball : MonoBehaviour
{
    public Transform ball;
    public float smoothTime = 0.3f;

    private Vector3 offset;
    private Vector3 velocity = Vector3.zero;

    private void Start()
    {
        offset = transform.position - ball.position;
    }

    private void LateUpdate()
    {
        Vector3 targetPosition = ball.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        transform.LookAt(ball);
    }
}

