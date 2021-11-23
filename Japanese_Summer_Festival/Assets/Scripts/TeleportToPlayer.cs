using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToPlayer : MonoBehaviour
{
    public Transform teleportPoint;

    void onCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Teleport"))
        {

            this.gameObject.transform.position = teleportPoint.transform.position;
        }
    }
}
