﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardMovement : MonoBehaviour
{

    public int damage;
    public float speed;
    private Rigidbody2D rb;

    //adds force to the game object so that it moves
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(0.0f, 1);
        rb.AddForce(movement * speed);
    }

    //upon collision with the player deals damage to them
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth player = hitInfo.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
    }
}
