using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableColliderOnGrab : MonoBehaviour
{
    Collider objCollider;

    void Start()
    {
        objCollider = GetComponent<Collider>();
    }

    public void ToggleCollision()
    {
        objCollider.enabled = !objCollider.enabled;
    }
    
}
