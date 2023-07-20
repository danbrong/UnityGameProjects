using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tron_PlayerUpState : Tron_PlayerBaseState
{
    
    public float speed = 1000f;
    private Rigidbody rigb;
    
    public override void EnterState(Tron_PlayerMoveFSM player)
    {
        rigb.velocity = Vector3.up * speed;
    }

    public override void OnCollisionEnter(Tron_PlayerMoveFSM player)
    {
        
    }

    public override void Update(Tron_PlayerMoveFSM player)
    {
        if (Input.GetButtonDown("w"))
        {
            player.Rigidbody.AddForce(Vector3.up * speed * 2);
        }
        else if (Input.GetButtonDown("a"))
        {
            player.TransitionToState(player.leftState);
        }
        else if (Input.GetButtonDown("d"))
        {
            player.TransitionToState(player.rightState);
        }
    }
}
