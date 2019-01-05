using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundaries
{
    public float xMin, xMax, yMin, yMax;
}


public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public Boundaries boundaries;

    private Rigidbody2D rb;

    void FixedUpdate()
    {
        //code for player movement
        rb = GetComponent<Rigidbody2D>();
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.AddForce(movement * speed);

        //code keeps player within play field
        rb.position = new Vector2
            (
            Mathf.Clamp (rb.position.x, boundaries.xMin, boundaries.xMax),
            Mathf.Clamp (rb.position.y, boundaries.yMin, boundaries.yMax)
            );
    }

}
