using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tron_P2Win : MonoBehaviour
{
    // Variable Declaration
    public GameObject P2WinMsg;
    public TextMeshProUGUI P2winMessage;

    public void P2WinPopup()
    {
        // Find Lose Msg object and Set Active
        if (P2WinMsg.CompareTag("Lose Msg") == true)
        {
            P2winMessage.enabled = true;
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        // Destroy Player on contact and set Lose
        Destroy(gameObject);
        P2WinPopup();
    }
}
