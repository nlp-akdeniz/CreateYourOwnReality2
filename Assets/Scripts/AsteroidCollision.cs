using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollision : MonoBehaviour
{
    [SerializeField] private GameObject asteroidExplosionGo;


    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Asteroid")
        {
            //do some stuff

            Debug.Log("U hit me with lazer beam");

            Instantiate(asteroidExplosionGo, collision.transform.position, collision.transform.rotation);

            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
        else
        {
            Destroy(gameObject);

        }
    }
}
