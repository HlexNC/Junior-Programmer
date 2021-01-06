using UnityEngine;

namespace Counter.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [Space] [Header("Controller")]
        public CharacterController controller;
        [SerializeField] private float speed = 20;
        [Space] [Header("Scroll")]
        public float mouseScroll;
        
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            //get player input 
            float inputXAxis = Input.GetAxis("Horizontal");
            float inputZAxis = Input.GetAxis("Vertical");
            //transform local position
            Vector3 move = transform.right * inputXAxis + transform.forward * inputZAxis;
            controller.Move(move * (speed * Time.deltaTime));

            mouseScroll = Input.GetAxis("Mouse ScrollWheel");
        }
    }
}
