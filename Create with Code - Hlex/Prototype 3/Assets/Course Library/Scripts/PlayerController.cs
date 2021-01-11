using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Course_Library.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        // Start is called before the first frame update
        private Rigidbody _playerRb;
        private Animator _playerAnim;
        private AudioSource _playerAudio;
        public float jumpForce;
        public float gravityModifier ;
        public ParticleSystem dirtParticle;
        public ParticleSystem boomParticle;
        public AudioClip jumpAudio;
        public AudioClip boomAudio;
        [FormerlySerializedAs("_isOnGround")] public bool isOnGround = true;
        [FormerlySerializedAs("_gameOver")] public bool gameOver;
        private static readonly int JumpTrig = Animator.StringToHash("Jump_trig");
        private static readonly int DeathB = Animator.StringToHash("Death_b");
        private static readonly int DeathTypeINT = Animator.StringToHash("DeathType_int");

        void Start()
        {
            _playerRb = GetComponent<Rigidbody>();
            _playerAnim = GetComponent<Animator>();
            _playerAudio = GetComponent<AudioSource>();
            Physics.gravity *= gravityModifier;

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
            {
                _playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isOnGround = false;
                _playerAnim.SetTrigger(JumpTrig);
                dirtParticle.Stop();
                _playerAudio.PlayOneShot(jumpAudio);
                
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Obstacle"))
            {
                Debug.Log("Game Over");
                gameOver = true;
                boomParticle.Play();
                dirtParticle.Stop();
                _playerAnim.SetBool(DeathB, true);
                _playerAnim.SetInteger(DeathTypeINT, 1);
                _playerAudio.PlayOneShot(boomAudio);

            }
            else if (collision.gameObject.CompareTag("Ground"))
            {
                isOnGround = true;
                dirtParticle.Play();
            }
        }
    }
}
