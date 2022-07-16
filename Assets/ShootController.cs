using UnityEngine;

public class ShootController : MonoBehaviour
{
    public GameObject projectile;
    public float fireRate;

    private SpriteRenderer _renderer;
    private float shootDelay;

    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Shoot();
        }

        shootDelay -= Time.deltaTime; // Decrease Shoot Delay over Time
    }

    private void Shoot()
    {
        if (shootDelay < 0)
        {
            shootDelay = fireRate; // Set the Shoot Delay with Fire Rate again
                         // Created                     //Prefab
            GameObject currentProjectile = Instantiate(projectile, this.transform.position, Quaternion.identity);
            if(_renderer.flipX)
                currentProjectile.GetComponent<BulletController>().speed *= -1;
        }
    }
}
