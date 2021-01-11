using UnityEngine;
using UnityEngine.Analytics;

namespace Course_Library.Scripts
{
    public class MoveLeft : MonoBehaviour
    {
        // Start is called before the first frame update
        private float _speed = 30.0f;
        private PlayerController _playerControllerScript;
        void Start()
        {
            _playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        }

        // Update is called once per frame
        void Update()
        {
            if (_playerControllerScript.gameOver == false)
            {
                transform.Translate(Vector3.left * (Time.deltaTime * _speed));
            }

            if (transform.position.x < -15 && gameObject.CompareTag("Obstacle"))
            {
                Destroy(gameObject);
            }
        }
    }
}
