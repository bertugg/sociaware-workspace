using System;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGrounded;
    public Animator animator;
    public float coyoteTimer = .2f;
    
    private float currentTime;
    private bool isCoyoteHandicapEnabled;

    private void Update()
    {
        if (isCoyoteHandicapEnabled == true && currentTime <= 0)
        {
            isGrounded = false;
            animator.SetBool("Grounded", false);
            isCoyoteHandicapEnabled = false;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.transform.CompareTag("Plataforma"))
        {
            isGrounded = true;
            animator.SetBool("Grounded", true);
            isCoyoteHandicapEnabled = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.CompareTag("Plataforma"))
        {
            currentTime = coyoteTimer;
            isCoyoteHandicapEnabled = true;
        }
    }
}
