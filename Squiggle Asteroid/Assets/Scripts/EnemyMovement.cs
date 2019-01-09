﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class EnemyMovement : MonoBehaviour
{

    public float speed;
    public int damage;
    private Rigidbody2D rb;
    public Boundary boundary;

    void Start()
    {


    }

    void FixedUpdate()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(0.0f, 1);
        rb.AddForce(movement * speed);

        rb.position = new Vector2
            (
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax)
            );
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Hazard")|| other.CompareTag("Enemy"))
        {
            return;
        }
     }

    void OnTriggerEnter2D(Collider2D hit)
    {

        PlayerHealth player = hit.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }       
    }
}
