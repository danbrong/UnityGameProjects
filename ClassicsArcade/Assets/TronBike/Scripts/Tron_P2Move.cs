using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tron_P2Move : MonoBehaviour
{
    // Movement Keys
    public KeyCode UpArrow;
    public KeyCode DownArrow;
    public KeyCode LeftArrow;
    public KeyCode RightArrow;

    // Variable Declaration
    public float speed2;
    private Rigidbody rigb2;
    public GameObject wallPrefab2;
    public GameObject enemy2;


    // Collider Declaration
    Collider wall2;
    Collider pCollider2;

    // Lightwall Spawn Function
    void SpawnWall2()
    {
        GameObject g = Instantiate(wallPrefab2);
        wall2 = g.GetComponent<Collider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //enemy = GameObject.Find("Enemy");
        // Find RigidBody on Player Object
        rigb2 = GetComponent<Rigidbody>();
        SpawnWall2();
    }

    // Update is called once per frame

    void Update()
    {
        // When CPU dies, set speed to 0 and turn off collider
        pCollider2 = GetComponent<Collider>();
        if (enemy2 == null)
        {
            pCollider2.enabled = false;
            speed2 = 0;
        }

        // Copy of SpawnWall Declaration, for some reason helps smooth out movement
        void SpawnWall2()
        {
            GameObject g = Instantiate(wallPrefab2, transform.position, Quaternion.identity);
            wall2 = g.GetComponent<Collider>();
        }

        // Initial Speed and Direction of Player
        transform.Translate(Vector3.down * speed2 * Time.deltaTime);
        SpawnWall2();

        // Move Implementation - Set Direction
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, -90);
            SpawnWall2();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, 90);
            SpawnWall2();
        }

        // Move Implementation #2 - Set Speed
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            speed2 = speed2 / 2;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            speed2 = speed2 * 2;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            speed2 = speed2 * 1.2f;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            speed2 = speed2 / 1.2f;
        }
    }
}
