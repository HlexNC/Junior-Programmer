using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerFollow : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    // private float turnSpeed = 20.0f;
    // private float rightInput;
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        // rightInput = Input.GetAxis("Horizontal");

        transform.position = player.transform.position + new Vector3(0, 4, (float) -6.6);
       // transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * rightInput);
    }
}
