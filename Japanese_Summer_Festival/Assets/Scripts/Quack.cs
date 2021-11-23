using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quack : MonoBehaviour
{

    public AudioSource source;
    public AudioClip quack;

    public void squeeze()
    {
        source.PlayOneShot(quack);
    }
}
