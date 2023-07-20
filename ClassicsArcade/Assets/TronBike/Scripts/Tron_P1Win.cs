using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tron_P1Win : MonoBehaviour
{
    // Variable Declaration
    public GameObject P1WinMsg;
    public TextMeshProUGUI P1winMessage;

    public void P1WinPopup()
    {
        // Find Win Msg object and Set Active
        if (P1WinMsg.CompareTag("Win Msg") == true)
        {
            P1winMessage.enabled = true;
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        // Destroy Enemy on contact and Set Win
        Destroy(gameObject);
        P1WinPopup();
    }

}
