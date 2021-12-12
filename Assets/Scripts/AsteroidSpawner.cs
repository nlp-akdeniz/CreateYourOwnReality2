using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [Header("Size of the spawn area")]
    public Vector3 size;

    [Header("Rate of instantiation")]
    public float spawnRate = 1f;

    [Header("Model used to instantiate  ")]
    public GameObject asteroidModel;

    [Header("Asteroid Parent")]
    public Transform asteroidParent;

    private float nextSpawn = 0;

    private void OnDrawGizmos() // works like update,it shows everything in editor.
    {                           //(Read Value,Green Value, Blue Value,alpha-transparent)
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        Gizmos.DrawCube(transform.position, size); //  create a 3d cube
    }



    private void Update()
    {   //Timer to control the spawning (time in seconds since the start of the game)
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            // call the function to create an asteroid
            SpawnAnAsteriod();

        }
    }




    private void SpawnAnAsteriod()
    {


        //get a random position for the asteroid.
        Vector3 spawnPoint = transform.position + new Vector3(Random.Range(-size.x / 2, size.x / 2),
                                                              Random.Range(-size.y / 2, size.y / 2),
                                                              Random.Range(-size.z / 2, size.z / 2));

        //for variation while creating asteriods
        //Quaternion asteroidRotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));   
        GameObject asteriod = Instantiate(asteroidModel, spawnPoint, transform.rotation);

        asteriod.transform.SetParent(asteroidParent);
    }




}
