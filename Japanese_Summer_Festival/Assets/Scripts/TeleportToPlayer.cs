using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToPlayer : MonoBehaviour
{
    public Transform teleportPoint;

    void Start()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Teleport"))
        {
            Debug.Log("Colliding with the teleport object");
            this.gameObject.transform.position = teleportPoint.transform.position;
        }
    }
}
