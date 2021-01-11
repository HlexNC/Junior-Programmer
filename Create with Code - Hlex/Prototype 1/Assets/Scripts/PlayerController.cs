using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 20.0f;
    private float turnSpeed = 20.0f;
    private float _forwardInput;
    private float _rightInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _forwardInput = Input.GetAxis("Vertical");
        _rightInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * (Time.deltaTime * speed * _forwardInput));
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * _rightInput);
    }
}
