using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaserGun : MonoBehaviour
{
    public Transform laserParent;
    public Animator gunAnimator;
    public GameObject laserBeamModel;
    public Transform laserSpawnPoint;
    
    public void FireGun()
    {
        //access the animator on the gun model
        gunAnimator.SetTrigger("Fire");
        //when the trigger is pressed,play the auşdı
        GetComponent<AudioSource>().Play();
        Debug.Log("Freaking laser gun");
        //instatite the laser beam
        GameObject generatedLaserBeam = Instantiate(laserBeamModel,laserSpawnPoint.position,laserSpawnPoint.rotation);
        //put the laser in to th correct parent object -tidy heriarchy
        generatedLaserBeam.transform.SetParent(laserParent);
        
    }
}
