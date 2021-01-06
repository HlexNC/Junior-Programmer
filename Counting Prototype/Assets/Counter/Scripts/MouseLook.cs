using UnityEngine;

namespace Counter.Scripts
{
    public class MouseLook : MonoBehaviour
    {
        // Start is called before the first frame update
        public float mouseSensitivity = 100f;
        private float _mouseRotation = 0;
        [Space] [Header("Player")] 
        public Transform playerTransform;
        [Space] [Header("Ball")]
        public GameObject ball;
        void Start()
        {
            //lock the mouse
            Cursor.lockState = CursorLockMode.Locked;
        }

        // Update is called once per frame
        void Update()
        {
            //get mouse coordinates;
            float mouseHorizontal = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseVertical = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
            //limit Y Axis
            _mouseRotation -= mouseVertical;
            _mouseRotation = Mathf.Clamp(_mouseRotation, -90f, 90f);
            // Rotate on X, Y Axis
            transform.localRotation = Quaternion.Euler(_mouseRotation, 0, 0);
            playerTransform.Rotate(Vector3.up * mouseHorizontal);
            //throw a ball on mouse down
            if (Input.GetMouseButtonDown(0))
            {
                GameObject gameObject = Instantiate(ball, transform.position + transform.forward + playerTransform.forward, transform.rotation);
            }
        }
    }
}
