﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour {

    public float speed;
    public int damage;
    private Rigidbody2D rb;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(0.0f, 3);
        rb.AddForce(movement * speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "HazardHealth")
        {
            return;
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth player = hitInfo.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}