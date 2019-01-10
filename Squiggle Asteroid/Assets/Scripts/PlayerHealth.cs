using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    //code establishes player health and how the player takes damage and dies
    public int health;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    //player dies(is destroyed) and is taken to the game over scene
    void Die()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(2);
    }
}
