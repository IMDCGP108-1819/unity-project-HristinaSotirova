using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardHealth : MonoBehaviour
{

    //code establishes how much health hazards have and how they take damage
    public int health;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    //when the object dies it is destroyed
    void Die()
    {
            Destroy(gameObject);
    }
    
}
