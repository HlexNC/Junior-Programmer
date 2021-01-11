using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float TopBounds = 30.0f;
    private float BottomBounds = -10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > TopBounds)
            Destroy(gameObject);
        else if (transform.position.z < BottomBounds)
            Destroy(gameObject);
    }
}
