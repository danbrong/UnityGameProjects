using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceInvaders_Enemy : MonoBehaviour
{

    private float _speed = 3.0f;

    UIManager uiManager;

    private void Awake()
    {
        uiManager = GameObject.Find("Lifes").GetComponent<UIManager>();
    }


    void Update()
    {
        MoveMovent();
        Borders();
    }

    void MoveMovent()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
    }

    void Borders()
    {
        if (transform.position.y <= -5.92f)
        {
            Destroy(this.gameObject);

            // Accessing the UIManager
            uiManager.PlayerLife();
        }
    }

}
