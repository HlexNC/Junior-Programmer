using UnityEngine;

namespace Challenge_2.Scripts
{
    public class GameBounds : MonoBehaviour
    {
        // Start is called before the first frame update
        private float _leftBounds = -30;
        private float _rightBounds = 10;
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        if (_leftBounds > transform.position.x)
            Destroy(gameObject);
        else if (_rightBounds < transform.position.x)
            Destroy(gameObject);
        }
    }
}
