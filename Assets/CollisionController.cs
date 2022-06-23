using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionController : MonoBehaviour
{
    public PlayerController player;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Key"))
        {
            player.hasKey = true;
        }

        if (other.transform.CompareTag("Door"))
        {
            if (player.hasKey)
            {
                Destroy(other.gameObject);
            }
        }
        
        if (other.transform.CompareTag("Objective"))
        {
            LevelController.LoadNextLevel();
        }


        if (other.transform.CompareTag("Enemy"))
        {
            LevelController.RestartLevel();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Key"))
        {
            player.hasKey = true;
            Destroy(other.gameObject);
        }
    }
}
