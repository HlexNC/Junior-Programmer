using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Course_Library.scripts
{
    public class GameManager : MonoBehaviour
    {
        // Start is called before the first frame update
        public List<GameObject> targets;
        public TextMeshProUGUI scoreTextMeshProUGUI;
        public TextMeshProUGUI gameOverTextMeshProUGUI;
        public TextMeshProUGUI bombOnTextMeshProUGUI;
        public Button restartButton;
        public int bombOn = 3;
        public bool gameOn;
        private int _score = 0;
        private float _spawnRate = 1.0f;
        private void Start()
        {
            gameOn = true;
            StartCoroutine(SpawnTarget());
            Score(0);
            Bomb(0);
        }

        // Update is called once per frame
        void Update()
        {
            if (bombOn == 0)
            {
                GameOver();
            }
        }

        public void Bomb(int bombToSub)
        {
            bombOn -= bombToSub;
            bombOnTextMeshProUGUI.text = "Bomb: " + bombOn;
        }
        public void Score(int scoreToAdd)
        {
            _score += scoreToAdd;
            scoreTextMeshProUGUI.text = "Score: " + _score;
            
            
        }

        IEnumerator SpawnTarget()
        {
            while (gameOn)
            {
                yield return new WaitForSeconds(_spawnRate);
                int index = Random.Range(0, targets.Count);
                Instantiate(targets[index]);
            }
        }

        public void GameOver()
        {
            
            gameOn = false;
            gameOverTextMeshProUGUI.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
        }

        public void RestartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
