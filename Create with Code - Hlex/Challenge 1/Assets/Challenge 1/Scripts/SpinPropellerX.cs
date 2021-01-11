using UnityEngine;

namespace Challenge_1.Scripts
{
    public class SpinPropellerX : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.forward, 200.0f);
        }
    }
}
