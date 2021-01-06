using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballThrow : MonoBehaviour
{
    private Rigidbody ballRigidbody;
    public float force = 45;
    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
        ballRigidbody.AddForce(transform.forward * force * 1000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
