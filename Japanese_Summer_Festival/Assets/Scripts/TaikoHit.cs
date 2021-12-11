using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaikoHit : MonoBehaviour
{

    public AudioSource source;
    public AudioClip don;
    public AudioClip ka;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("InnerDrum"))
        {
            source.PlayOneShot(don);
        }
        else if (other.gameObject.CompareTag("OuterDrum"))
        {
            source.PlayOneShot(ka);
        }
    }
}
