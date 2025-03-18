using System.Data.Common;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Scorer : MonoBehaviour
{
    int score = 0;
     void OnCollisionEnter(Collision other){
        if(other.gameObject.tag != "Hit"){
            score++; 
            Debug.Log("you hit this many time = " + score);
        }
            
    }
}
