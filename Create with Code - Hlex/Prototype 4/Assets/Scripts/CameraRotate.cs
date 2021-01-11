using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public int cameraRotateSpeed;
    private float _userInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _userInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up , cameraRotateSpeed * _userInput * Time.deltaTime);
    }
}
