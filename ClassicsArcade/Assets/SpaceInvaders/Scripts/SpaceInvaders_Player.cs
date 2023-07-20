using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpaceInvaders_Player : MonoBehaviour
{
    public float speed = 5.0f;
    public bool fire = true;

    [SerializeField] private GameObject _laserContainer;
    [SerializeField] private GameObject laserPrefab;

    private float verticalInput;
    private float horizontalInput;
    private float fireRate = .05f;
   

    UIManager uiManager;


    private void Awake()
    {
        uiManager = GameObject.Find("Lifes").GetComponent<UIManager>();
    }


    void Update()
    {
        Movement();
        ShootLaser();
    }

    void ShootLaser()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(laserPrefab != null)
            {
                if (fire)
                {
                    SpaceInvaders_AudioManager.Instance.PlayLaser();
                    StartCoroutine(FireRate()); 
                    GameObject newlaser = Instantiate(laserPrefab, new Vector3(transform.position.x, transform.position.y + 1f, 0f), Quaternion.identity);
                    newlaser.transform.parent = _laserContainer.transform;
                }
                   
            }  
        }
    }



    IEnumerator FireRate()
    {
        GameObject FiringBar = GameObject.Find("FireRate");
        FiringBar.transform.localScale = new Vector3(.1f, 1f, 1f);
        fire = false;
        for (float i = .1f; i < 1; i+=.1f)
        {
            FiringBar.transform.localScale = new Vector3(.1f + i, 1f, 1f);
            yield return new WaitForSeconds(fireRate);
        }
        fire = true;
    }


    void Movement()
    {
        // Movement
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime);

        // Vertical Borders
        if (transform.position.y <= -5)
        {
            transform.position = new Vector3(transform.position.x, -5f, 0);
        }
        else if (transform.position.y >= -.05f)
        {
            transform.position = new Vector3(transform.position.x, -.05f, 0);
        }

        // Horizontal Borders
        if (transform.position.x <= -10.30f)
        {
            transform.position = new Vector3(10.30f, transform.position.y, 0);
        }
        else if (transform.position.x >= 10.30f)
        {
            transform.position = new Vector3(-10.30f, transform.position.y, 0);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(collision.gameObject);
            uiManager.PlayerLife();
        }
    }
}
