using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tron_PlayerMove : MonoBehaviour
{
    // Movement Keys
    public KeyCode W;
    public KeyCode A;
    public KeyCode S;
    public KeyCode D;

    // Variable Declaration
    public float speed;
    private Rigidbody rigb;
    public GameObject wallPrefab;
    public GameObject enemy;
    

    // Collider Declaration
    Collider wall;
    Collider pCollider;

    // Lightwall Spawn Function
    void SpawnWall()
    {
        GameObject g = Instantiate(wallPrefab);
        wall = g.GetComponent<Collider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //enemy = GameObject.Find("Enemy");
        // Find RigidBody on Player Object
        rigb = GetComponent<Rigidbody>();
        SpawnWall();
    }

    // Update is called once per frame
   
    void Update()
    {
        // When CPU dies, set speed to 0 and turn off collider
        pCollider = GetComponent<Collider>();
        if (enemy == null)
        {
            pCollider.enabled = false;
            speed = 0;
        }

        // Copy of SpawnWall Declaration, for some reason helps smooth out movement
        void SpawnWall()
        {
            GameObject g = Instantiate(wallPrefab, transform.position, Quaternion.identity);
            wall = g.GetComponent<Collider>();
        }

        // Initial Speed and Direction of Player
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        SpawnWall();

        // Move Implementation - Set Direction
        if (Input.GetKeyDown("d"))
        {
            transform.Rotate(0, 0, -90);
            SpawnWall();
        }
        if (Input.GetKeyDown("a"))
        {
            transform.Rotate(0, 0, 90);
            SpawnWall();
        }

        // Move Implementation #2 - Set Speed
        if (Input.GetKeyDown("s"))
        {
            speed = speed / 2;
        }
        if (Input.GetKeyUp("s"))
        {
            speed = speed * 2;
        }
        if (Input.GetKeyDown("w"))
        {
            speed = speed * 1.2f;
        }
        if (Input.GetKeyUp("w"))
        {
            speed = speed / 1.2f;
        }


        // Debug Log
        if (Input.GetKeyDown(W))
        {
            Debug.Log("Up");
            Debug.Log(rigb.velocity);
        }
        else if (Input.GetKeyDown(A))
        {
            Debug.Log("Left");
            Debug.Log(rigb.velocity);
        }
        else if (Input.GetKeyDown(S))
        {
            Debug.Log("Down");
            Debug.Log(rigb.velocity);
        }
        else if (Input.GetKeyDown(D))
        {
            Debug.Log("Right");
            Debug.Log(rigb.velocity);
        }
    }
}
