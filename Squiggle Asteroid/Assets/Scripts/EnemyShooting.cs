using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;

    //creates endless stream of shots with a set rate with a delay after each shot
    void Start()
    {
        InvokeRepeating("Fire", delay, fireRate);
    }

    //instantiates shot prefabs at shot spawn location
    void Fire()
    {
        GameObject item = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        Destroy(item, 2f);
    }

}
