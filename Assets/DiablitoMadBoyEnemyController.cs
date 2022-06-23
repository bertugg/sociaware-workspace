using UnityEngine;

public class DiablitoMadBoyEnemyController : MonoBehaviour
{
    public float movementSpeed;
   
    private Vector2 movementVector;
    private Rigidbody2D rigidBody;
    private Animator animator;
    private SpriteRenderer renderer;
 
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>(); // Get the Rigidbody from the player GameObject
        animator = GetComponent<Animator>(); // Get the Animator from the player GameObject
        renderer = GetComponent<SpriteRenderer>(); // Get the Sprite Renderer from the player GameObject
    }
    
    void Update()
    {
        movementVector = new Vector2(movementSpeed, 0);
        transform.Translate(movementVector * Time.deltaTime); // Horizontal Movement
        animator.SetFloat("Speed", movementVector.magnitude);
        
        if (movementVector.x < 0)
        {
            renderer.flipX = true;
        }
        else if (movementVector.x > 0)
        {
            renderer.flipX = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EnemyRotator"))
        {
            movementSpeed = movementSpeed * -1;
        }
    }
}
