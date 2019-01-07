using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{

    public float speed;
    public int damage;
    private Rigidbody2D rb;

    void Start () {

        rb = GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(0.0f, 3);
        rb.AddForce(movement * speed);
       
    }

     void OnTriggerEnter2D (Collider2D hitInfo)
    {    
        HazardHealth hazard = hitInfo.GetComponent<HazardHealth>();
        if (hazard != null)
        {
            hazard.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

}
