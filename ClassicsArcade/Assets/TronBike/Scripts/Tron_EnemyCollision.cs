using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tron_EnemyCollision : MonoBehaviour
{
    // Variable Declaration
    public GameObject WinMsg;
    public TextMeshProUGUI winMessage;

    public void WinPopup()
    {
        // Find Win Msg object and Set Active
        if (WinMsg.CompareTag("Win Msg") == true)
        {
            winMessage.enabled = true;
        }
        
    }
    public void OnTriggerEnter(Collider other)
    {
        // Destroy Enemy on contact and Set Win
        Destroy(gameObject);
        WinPopup();
    }
    
}
