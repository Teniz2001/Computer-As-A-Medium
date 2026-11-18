# Computer As A Medium
### This is a repo for the Computer As A Medium Fall 2026.
### Group Name: [Strawhat Pirates]
### Group Members: [Andre Belokonev]
# Task 1 and 3: Andrew
# Task 2 Deniz
# 


#using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float destroyTime = 3f;
    public int damage = 10;
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocity = transform.up * speed;
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Bullet collided with: " + other.name);

        if (other.CompareTag("Enemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();

            if (enemy != null)
            {
                Debug.Log("Enemy detetcted");

                enemy.TakeDamage(damage);

                Destroy(gameObject);
            }
        }
    }
}