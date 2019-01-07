using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyMovement : MonoBehaviour {

    public float speed;

    private Rigidbody2D rb;

    private float move;
    public float movement;
    public Vector2 startWait;
    public Vector2 movementTime;
    public Vector2 movementWait;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(0.0f, 1);
        rb.AddForce(movement * speed);
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        yield return new WaitForSeconds(Random.Range(startWait.x, startWait.y));
        while (true)
        {
            move = Random.Range(1, move) * -Mathf.Sign(transform.position.x;
            yield return new WaitForSeconds();
            move = 0;
            yield return new WaitForSeconds();
        }
    }

}
