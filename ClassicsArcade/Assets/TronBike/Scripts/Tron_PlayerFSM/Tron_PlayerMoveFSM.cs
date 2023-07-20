using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tron_PlayerMoveFSM : MonoBehaviour
{
    // Movement Keys
    public KeyCode W;
    public KeyCode A;
    public KeyCode S;
    public KeyCode D;

    // Movement Speed
    public float speed;
    private Rigidbody rigb;

    // State Declaration
    public Rigidbody Rigidbody
    {
        get { return rigb; }
    }

    private Tron_PlayerBaseState currentState;

    public Tron_PlayerBaseState CurrentState
    {
        get { return currentState; }
    }

    public readonly Tron_PlayerUpState upState = new Tron_PlayerUpState();
    public readonly Tron_PlayerDownState downState = new Tron_PlayerDownState();
    public readonly Tron_PlayerLeftState leftState = new Tron_PlayerLeftState();
    public readonly Tron_PlayerRightState rightState = new Tron_PlayerRightState();

    

    // Start is called before the first frame update
    void Start()
    {
        TransitionToState(upState);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.Update(this);
    }

    private void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionEnter(this);
    }

    public void TransitionToState(Tron_PlayerBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}
