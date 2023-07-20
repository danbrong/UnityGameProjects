using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tron_TrailCollision : MonoBehaviour
{
    void Update()
    {
        IEnumerator DelayCollider()
        {
            yield return new WaitForSeconds(.25f);
            this.GetComponent<Collider>().enabled = true;
        }

        StartCoroutine(DelayCollider());
    }
}
