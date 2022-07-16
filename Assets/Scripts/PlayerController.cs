using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 5;
    public float jumpForce = 10;
    public GroundCheck groundCheck;
    public IngameUIController ui;

    public bool hasKey = false;
   
    private Animator animator;
    private Vector2 movementVector;
    private Rigidbody2D rigidBody;
    private SpriteRenderer renderer;
    private bool isJumping;

    private int health;
    
    

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>(); // Get the Rigidbody from the player GameObject
        animator = GetComponent<Animator>(); // Get the Animator from the player GameObject
        renderer = GetComponent<SpriteRenderer>(); // Get the Sprite Renderer from the player GameObject

        health = 3;
        ui.UpdateHealth(health);
    }

    void Update()
    {
        movementVector = new Vector2(Input.GetAxis("Horizontal"), 0);
        transform.Translate(movementVector * Time.deltaTime * playerSpeed); // Horizontal Movement
        animator.SetFloat("Speed", movementVector.magnitude);
        if (movementVector.x < 0)
        {
            renderer.flipX = true;
        }
        else if (movementVector.x > 0)
        {
            renderer.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(); // <- is a function 
        }
    }

    private void Jump()
    {
        //if (groundCheck.isGrounded == true) // isJumping != true
        {
            rigidBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    public void Damage(int point)
    {
        health -= point;
        ui.UpdateHealth(health);
        if(health <= 0)
            LevelController.RestartLevel();
    }

    public void AcquireKey()
    {
        hasKey = true;
        ui.UpdateKey(hasKey);
    }
}
