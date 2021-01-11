using UnityEngine;

namespace Challenge_1.Scripts
{
    public class FollowPlayerX : MonoBehaviour
    {
        public GameObject plane;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.position = plane.transform.position + new Vector3(20, 3, 5);
        }
    }
}
