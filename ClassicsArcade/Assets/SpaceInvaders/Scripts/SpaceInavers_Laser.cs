using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpaceInavers_Laser : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;

    UIManager uiManager;


    private void Awake()
    {
        uiManager = GameObject.Find("Score").GetComponent<UIManager>();
    }


    void Update()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
        DestroyLaser();
    }

    void DestroyLaser()
    {
        if (transform.position.y >= 5.80)
        {
            Destroy(this.gameObject);
        }
    }

    // Create a method that detects when the laser gameobject hits something
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {

            Destroy(this.gameObject);
            Destroy(collision.gameObject);

            // Accessing the UIManager
            uiManager.PlayerScoreing();

            // Accessing the Enemy Script for audio method
            SpaceInvaders_AudioManager.Instance.PlayExplosion();


 


        }
    }

}
