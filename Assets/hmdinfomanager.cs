using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class hmdinfomanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Is Device Active"+XRSettings.isDeviceActive);
        Debug.Log("device:name"+XRSettings.loadedDeviceName);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
