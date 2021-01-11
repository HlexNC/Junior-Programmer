using UnityEngine;
using Random = UnityEngine.Random;

namespace Course_Library.scripts
{
    public class Target : MonoBehaviour
    {
        // Start is called before the first frame update
        private Rigidbody _targetRb;
        private GameManager _gameManager;
        public int scoreValue;
        public ParticleSystem explosionParticle;
        void Start()
        {
            _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
            _targetRb = GetComponent<Rigidbody>();
            _targetRb.AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);
            _targetRb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10),
                Random.Range(-10, 10), ForceMode.Impulse);
            transform.position = new Vector2(Random.Range(-4, 4), -2);
        }

        // Update is called once per frame
        void Update()
        {
        }

        private void OnMouseDown()
        {
            Destroy(gameObject);
            _gameManager.Score(scoreValue);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            if (gameObject.CompareTag("bad"))
            {
                _gameManager.Bomb(1);
            }
            
        }

        private void OnCollisionEnter(Collision other)
        {
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (gameObject.CompareTag("good"))
            {
                _gameManager.Score(-5);
            }
            else if (gameObject.CompareTag("best"))
            {
                _gameManager.Score(-15);
            }
            Destroy(gameObject);
        }
    }
}
