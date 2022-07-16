using System;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;
    public float lifeTime;

    private void Start()
    {
        Destroy(this.gameObject, lifeTime);
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        transform.Rotate(0,0,2);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collided with " + other.transform.name);
        if (other.transform.CompareTag("Enemy"))
        {
            DiablitoMadBoyEnemyController diablitoController = other.GetComponent<DiablitoMadBoyEnemyController>(); 
            if(diablitoController)
                diablitoController.Die();
            
            Destroy(this.gameObject);
        }

        if (other.CompareTag("Platform"))
        {
            Destroy(this.gameObject);
        }
    }
}
