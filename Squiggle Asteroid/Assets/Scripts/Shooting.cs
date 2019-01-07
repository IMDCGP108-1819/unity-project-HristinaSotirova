using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;
    public float spawnTime;

    //code creates a consistant stream of shots
    void Start()
    {
        InvokeRepeating("Shot", spawnTime, spawnTime);
    }

    //code spawns shots and has them self-destruct over time
    void Shot()
    {
        GameObject item = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        Destroy(item, 2f);
    }
}
