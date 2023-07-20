using UnityEngine;

public abstract class Tron_PlayerBaseState
{
    public abstract void EnterState(Tron_PlayerMoveFSM player);

    public abstract void Update(Tron_PlayerMoveFSM player);

    public abstract void OnCollisionEnter(Tron_PlayerMoveFSM player);
}
