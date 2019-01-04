using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

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
        Destroy(item, 2f);
    }
}
