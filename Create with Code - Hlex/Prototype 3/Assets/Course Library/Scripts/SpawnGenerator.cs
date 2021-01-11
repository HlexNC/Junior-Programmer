using UnityEngine;

namespace Course_Library.Scripts
{
    public class SpawnGenerator : MonoBehaviour
    {
        // Start is called before the first frame update
        public GameObject[] obstaclePrefabs;
        private int _obstacleRand;
        private PlayerController _playerControllerScript;
    
        void Start()
        {
            _playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
            InvokeRepeating("SpawnGen", 2.0f, 3.0f);
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        void SpawnGen()
        {
            if (_playerControllerScript.gameOver == false)
            {
                _obstacleRand = Random.Range(0, obstaclePrefabs.Length);
                Instantiate(obstaclePrefabs[_obstacleRand], new Vector3(25, 0, 0),
                    obstaclePrefabs[_obstacleRand].transform.rotation);
                
            }
        }
    }
}
