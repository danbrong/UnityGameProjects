using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tron_EnemyMove : MonoBehaviour
{
    // Variable Declaration
    public float speed;
    private Rigidbody rigb;
    public GameObject wallPrefab;
    public float delay;
    public float delay2;
    float timer;
    float timer2;
    public GameObject player;
    private RaycastHit hit;
    private Ray ray;
    public float rayDistance = 25f;

    // Audio Variables
    //public AudioClip idle;
    //public AudioClip left;
    //public AudioClip right;
    //public AudioClip crash;
    //private AudioSource CompFX;

    // Current Wall
    Collider wall;
    Collider eCollider;

    // Lightwall Spawn Function
    void SpawnWall()
    {
        GameObject g = Instantiate(wallPrefab);
        wall = g.GetComponent<Collider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("Player");
        // CPU starting Speed
        rigb = GetComponent<Rigidbody>();
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        SpawnWall();
    }

    // Update is called once per frame
    void Update()
    {
        // Copy of SpawnWall to smooth Movement
        void SpawnWall()
        {
            GameObject g = Instantiate(wallPrefab, transform.position, Quaternion.identity);
            wall = g.GetComponent<Collider>();
        }

        // Initial Movement and Initiate Light Trails
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        SpawnWall();
        //CompFX.PlayOneShot(idle);

        // Stop Movement When Player Object Destructs and Turn off Collider
        eCollider = GetComponent<Collider>();
        if (player == null)
        {
            eCollider.enabled = false;
            speed = 0;
            //CompFX.PlayOneShot(crash);
        }

        // Raycast Targetting
        ray = new Ray(transform.position, -transform.up);
        Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.red);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.distance < rayDistance)
            {
                // Delay for Direction Change
                timer += Time.deltaTime;
                if (timer > delay)
                {
                    float randomNum = Random.Range(0, 3);

                    //// If Implementation for Direction
                    //if (randomNum == 0)
                    //{
                    //    timer = 0;
                    //}
                    //else if (randomNum == 1)
                    //{
                    //    transform.Rotate(0, 0, 90);
                    //    SpawnWall();
                    //    timer = 0;
                    //}
                    //else if (randomNum == 2)
                    //{
                    //    transform.Rotate(0, 0, -90);
                    //    SpawnWall();
                    //    timer = 0;
                    //}

                    // Switch Case Implementation for Direction
                    switch (randomNum)
                    {
                        case 0:
                            timer = 0;
                            break;
                        case 1:
                            transform.Rotate(0, 0, 90);
                            SpawnWall();
                            timer = 0;
                            break;
                        case 2:
                            transform.Rotate(0, 0, -90);
                            SpawnWall();
                            timer = 0;
                            break;
                    }
                }
            }
        }

        // Delay for Direction Change
        timer2 += Time.deltaTime;
        if (timer2 > delay2)
        {
            float randomNum2 = Random.Range(0, 3);

            // Switch Case Implementation for Direction
            switch (randomNum2)
            {
                case 0:
                    timer2 = 0;
                    break;
                case 1:
                    transform.Rotate(0, 0, 90);
                    SpawnWall();
                    timer2 = 0;
                    break;
                case 2:
                    transform.Rotate(0, 0, -90);
                    SpawnWall();
                    timer2 = 0;
                    break;
            }
        }
    }
}

