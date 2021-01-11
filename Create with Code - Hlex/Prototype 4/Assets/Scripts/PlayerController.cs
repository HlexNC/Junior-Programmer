using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerSpeed;
    private Rigidbody _playerRb;
    private GameObject _playerDirection;
    public GameObject pickupIndicator;
    private float _playerInput;
    public bool hasPickup = false;
    private int _knockBackForce = 15;
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        _playerDirection = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        _playerInput = Input.GetAxis("Vertical");
        _playerRb.AddForce(_playerDirection.transform.forward * (playerSpeed * _playerInput));
        pickupIndicator.transform.position = transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            hasPickup = true;
            pickupIndicator.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(5);
        hasPickup = false;
        pickupIndicator.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPickup)
        {
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 knockBack = (collision.gameObject.transform.position - transform.position).normalized;
            enemyRb.AddForce(knockBack * _knockBackForce, ForceMode.Impulse);
        }
    }
}
