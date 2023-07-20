using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tron_PlayerCollision : MonoBehaviour
{
    // Variable Declaration
    public GameObject LoseMsg;
    public TextMeshProUGUI loseMessage;

    public void LosePopup()
    {
        // Find Lose Msg object and Set Active
        if (LoseMsg.CompareTag("Lose Msg") == true)
        {
            loseMessage.enabled = true;
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        // Destroy Player on contact and set Lose
        Destroy(gameObject);
        LosePopup();
    }
}
