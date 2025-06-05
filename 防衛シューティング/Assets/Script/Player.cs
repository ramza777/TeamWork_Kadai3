using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Assign your bullet prefab in the Inspector
    public float bulletSpeed = 20f; // Adjust bullet speed as needed

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)) 
        {
            Shoot();
        }
    }

    void Shoot()
    {
       
        Vector3 mouseScreenPosition = Input.mousePosition;

        
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mouseScreenPosition.x, mouseScreenPosition.y, Camera.main.transform.position.y)); // Assuming a 2D game or shooting along the XZ plane

        
        mouseWorldPosition.z = transform.position.z; 

        
        Vector2 shootDirection = (mouseWorldPosition - transform.position).normalized;

        
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

        
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            // Apply force to the bullet in the calculated direction
            rb.linearVelocity = shootDirection * bulletSpeed;
        }
        else
        {
            Debug.LogWarning("Bullet prefab is missing a Rigidbody2D component!");
        }
    }
}
