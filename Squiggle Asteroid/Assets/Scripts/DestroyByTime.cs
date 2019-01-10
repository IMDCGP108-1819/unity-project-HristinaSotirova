using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {

    public float lifetime;

    //destroys game objects after set amount of time
    void Start () {
        Destroy(gameObject, lifetime);
	}	
}
