using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
     if (other.tag == "Player")
        {
            GetComponent<Animator>().SetTrigger("open");
        }
    }
}
