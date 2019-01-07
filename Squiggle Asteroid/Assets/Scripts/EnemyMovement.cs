using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class EnemyMovement : MonoBehaviour {

    public float speed;
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


}
