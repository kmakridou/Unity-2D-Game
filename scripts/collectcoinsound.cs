using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectcoinsound : MonoBehaviour
{
    public AudioSource collectsound;
    void OnTriggerEnter2D(Collider2D other)
    {

        collectsound.Play();
        scorescript.theScore += 1;
        Destroy(gameObject);
    }
}
