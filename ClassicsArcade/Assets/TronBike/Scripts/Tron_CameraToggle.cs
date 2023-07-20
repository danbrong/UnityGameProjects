using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tron_CameraToggle : MonoBehaviour
{
    public GameObject camera;
    public GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            camera.SetActive(true);
        }

        if (Input.GetKeyDown("q"))
        {
            camera.SetActive(false);
        }
    }
}
