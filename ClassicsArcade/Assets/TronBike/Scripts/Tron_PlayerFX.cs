using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tron_PlayerFX : MonoBehaviour
{
    public GameObject Comp;
    public AudioClip normal;
    public AudioClip fast;
    public AudioClip slow;
    public AudioClip left;
    public AudioClip right;
    
    public AudioClip crash;
    private AudioSource PlayerFX;
    // Start is called before the first frame update
    void Start()
    {
        PlayerFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerFX.Play();
       
        if (Input.GetKeyDown("w"))
        {
            PlayerFX.PlayOneShot(fast);
        }
        if (Input.GetKeyUp("w"))
        {
            PlayerFX.Stop();
        }

        if (Input.GetKeyDown("s"))
        {
            PlayerFX.PlayOneShot(slow);
        }
        if (Input.GetKeyUp("s"))
        {
            PlayerFX.Stop();
        }

        if (Input.GetKeyDown("d"))
        {   
            PlayerFX.PlayOneShot(right);
        }
        if (Input.GetKeyDown("a"))
        {
            PlayerFX.PlayOneShot(left);
        }

        if (Comp == null)
        {
            PlayerFX.PlayOneShot(crash);
        }
    }
}
