using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeamMove : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public float thrust =10f;
    public void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward*thrust;
        Destroy(gameObject,2f);

    }
}
