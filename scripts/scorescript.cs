using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour
{
    public GameObject scoretext;
    public static int theScore;
    

     void Update()
    {
        scoretext.GetComponent<Text>().text = "SCORE: " + theScore;
        
    }
}
