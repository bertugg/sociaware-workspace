using System;
using UnityEngine;

public class DiablitoMadBoyEnemyController : MonoBehaviour
{
    public float movementSpeed;
    public GameObject dieProjectile;
   
    private Vector2 movementVector;
    private Rigidbody2D rigidBody;
    private Animator animator;
    private SpriteRenderer renderer;

    private bool isDead = false;
    
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>(); // Get the Rigidbody from the player GameObject
        animator = GetComponent<Animator>(); // Get the Animator from the player GameObject
        renderer = GetComponent<SpriteRenderer>(); // Get the Sprite Renderer from the player GameObject
    }
    
    void Update()
    {
        if (isDead == false)
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
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EnemyRotator"))
        {
            movementSpeed = movementSpeed * -1;
        }
    }

    public void Die()
    {
        animator.SetTrigger("Die");
        isDead = true;
        Destroy(this.gameObject, 2);
    }

    private void OnDestroy()
    {
        GameObject projectile1 =  Instantiate(dieProjectile, this.transform.position, Quaternion.identity);
        GameObject projectile2 =  Instantiate(dieProjectile, this.transform.position, Quaternion.identity);

        projectile1.GetComponent<BulletController>().speed *= -1;
        projectile1.tag = "Enemy";
        
        projectile2.tag = "Enemy";
    }
}
