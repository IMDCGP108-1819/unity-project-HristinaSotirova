using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{

    public float speed;
    public int damage;
    private Rigidbody2D rb;

    //adds force to the shots so that they move
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(0.0f, 3);
        rb.AddForce(movement * speed);
    }

    //upon collision with the player deals damage to them and destroys the shot game object
    void OnTriggerEnter2D(Collider2D hit)
    {
        PlayerHealth player = hit.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
