using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsMovement : MonoBehaviour
{
     [Header("Control the speed of the asteroid")]
     public float maxSpeed;
     public float minSpeed;
     public Vector3 movementDirection;
     private float _asteroidspeed = 10f;
   
     [Header("Control the rotational speed of the asteroid")]
     public float rotationSpeedMin;
     public float rotationSpeedMax;


     private float rotationSpeed;
     private float xAngle, yAngle, zAngle;
    

     // Start is called before the first frame update
    void Start()
    {
        //get a random speed for asteroid
        _asteroidspeed = Random.Range(minSpeed, maxSpeed);

        //get a random rotation
        xAngle = Random.Range(0, 360);
        yAngle = Random.Range(0, 360);
        zAngle = Random.Range(0, 360);
        transform.GetChild(0).transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
        rotationSpeed = Random.Range(rotationSpeedMin, rotationSpeedMax);
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementDirection * Time.deltaTime * _asteroidspeed);
        transform.GetChild(0).transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
    }
}
