using UnityEngine;

public class BallController : MonoBehaviour
{
    // public can be seen through Editor and Other Scripts
    // private can NOT be seen through any other scripts
    
//    public bool trueOrFalse; // Boolean Values have only true or false
//    private int integerValue; // 1 -4 0 128 99999
//    public float floatValue; // 0.567 -75.348 0 1.0
//    public string stringValue; // "Hello World" "I Love Coding (if you believe)" "Diogo"

    public float HorizontalSpeed;
    
    void Update() // Works in each Frame Renderer.
    {
        if (Input.GetKey(KeyCode.D))
        {
//          transform.position = transform.position + new Vector3(HorizontalSpeed * Time.deltaTime, 0f);
            transform.position += new Vector3(HorizontalSpeed * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
//            transform.position = transform.position - new Vector3(HorizontalSpeed * Time.deltaTime, 0f);
            transform.position -= new Vector3(HorizontalSpeed * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.W))
        {
//            transform.position = transform.position + VerticalSpeed * Time.deltaTime;
        }
    }
}
