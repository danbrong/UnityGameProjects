using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tron_EnemyFX : MonoBehaviour
{
    // Variable Declaration
    public GameObject Player;
    private GameObject Comp;
    private Vector3 oldEulerAngles;
    public AudioClip idle;
    public AudioClip left;
    public AudioClip right;
    public AudioClip crash;
    private AudioSource CompFX;

    // Start is called before the first frame update
    void Start()
    {
        CompFX = GetComponent<AudioSource>();
        Comp = GameObject.Find("Enemy");
        oldEulerAngles = Comp.transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player == null)
        {
            CompFX.PlayOneShot(crash);
        }
    }
}
