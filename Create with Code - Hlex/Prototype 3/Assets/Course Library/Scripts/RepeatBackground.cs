using UnityEngine;
using UnityEngine.Serialization;

namespace Course_Library.Scripts
{
    public class RepeatBackground : MonoBehaviour
    {
        // Start is called before the first frame update
        public Vector3 startPos;
        public float backgroundWidth;
        void Start()
        {
            startPos = transform.position;
            backgroundWidth = startPos.x - GetComponent<BoxCollider>().size.x / 2;
        }

        // Update is called once per frame
        void Update()
        {
            if (transform.position.x < backgroundWidth)
            {
                transform.position = startPos;
            }
            
        }
    }
}
