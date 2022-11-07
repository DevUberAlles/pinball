using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    
        void Awake () {
            Invoke ("HitBall", 1f);  // Calls HitBall in 1 second.
        }
         void HitBall(){
            GetComponent<Rigidbody>().AddForce (new Vector3 (0f, 0f, 20f), ForceMode.Impulse);
        } 
    

    
}
