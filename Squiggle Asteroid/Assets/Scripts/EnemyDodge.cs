using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDodge : MonoBehaviour {

    public float move;
    public float smoothing;
    public Vector2 startWait;
    public Vector2 moveTime;
    public Vector2 moveWait;
    private float currentSpeed;
    private float movement;
    private Rigidbody2D rb;

    //sets the speed of the enemy and starts coroutine
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentSpeed = rb.velocity.y;
        StartCoroutine(Move());
    }

    //a coroutine that makes the enemies move to the left or right based on their position in relation to the 0 on the y axis
    IEnumerator Move()
    {
        yield return new WaitForSeconds(Random.Range(startWait.x, startWait.y));

        while (true)
        {
            movement = Random.Range(1, move) * -Mathf.Sign(transform.position.x);
            yield return new WaitForSeconds(Random.Range(moveTime.x, moveTime.y));
            movement = 0;
            yield return new WaitForSeconds(Random.Range(moveWait.x, moveWait.y));
        }
    }

    //eases the enemies into the dodge
    void FixedUpdate()
    {
        float newMovement = Mathf.MoveTowards(rb.velocity.x, movement, Time.deltaTime * smoothing);
         rb.velocity = new Vector2(newMovement, currentSpeed);
    }


    
}
