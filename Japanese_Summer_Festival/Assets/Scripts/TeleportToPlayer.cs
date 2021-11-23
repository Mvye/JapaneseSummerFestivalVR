using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToPlayer : MonoBehaviour
{
    public Transform teleportPoint;
    Transform _transform;

    void Start()
    {
        _transform = this.transform;
    }
    void onCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Teleport"))
        {
            Debug.Log("Colliding with the teleport object");
            _transform.transform.position = teleportPoint.transform.position;
        }
    }
}
