using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour
{

    public float rotationSpeed;
    public float rotationTime;

    void Start()
    {
        Invoke("ChangeRotation", rotationTime);
    }

    void ChangeRotation()
    {
        if (Random.value > 0.5f)
        {
            rotationSpeed = -rotationSpeed;
        }
        Invoke("ChangeRotation", rotationTime);
    }


    void Update()
    {

        transform.Rotate(new Vector3(0, 0, rotationSpeed * Time.deltaTime));
    }
}
