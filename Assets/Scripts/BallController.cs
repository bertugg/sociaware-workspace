using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 HorizontalSpeed;
    public Vector3 VerticalSpeed;
    
    void Update() // Works in each Frame Renderer.
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + HorizontalSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - HorizontalSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + VerticalSpeed * Time.deltaTime;
        }
    }
}
