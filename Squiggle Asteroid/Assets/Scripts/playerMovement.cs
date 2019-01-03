using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundaries
{
    public float xMin, xMax, yMin, yMax;
}


public class playerMovement : MonoBehaviour {

    public float speed;
    public Boundaries boundaries;

    private Rigidbody2D rb;

    public GameObject shot;
    public Transform shotSpawn;
    public float spawnTime;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("Shot", spawnTime, spawnTime);
    }
            
    void Shot()
    {
        GameObject item = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        Destroy(item, 3f);
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.AddForce(movement*speed);

        rb.position = new Vector2
            (
            Mathf.Clamp (rb.position.x, boundaries.xMin, boundaries.xMax),
            Mathf.Clamp (rb.position.y, boundaries.yMin, boundaries.yMax)
            );
    }

}
