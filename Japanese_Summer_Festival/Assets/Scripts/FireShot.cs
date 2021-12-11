using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireShot : MonoBehaviour
{
    public GameObject bullet; //bullet game object to instantiate
    public GameObject bulletSP; //bullet start point

    public void TriggerPulled()
    {
        Instantiate(bullet, bulletSP.transform.position, bulletSP.transform.rotation);
        Debug.Log("Trigger was pulled");

    }
}
