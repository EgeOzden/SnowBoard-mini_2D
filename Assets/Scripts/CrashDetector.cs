using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{


    CircleCollider2D sorfcu_kafa;
 
    private void Start()
    {
        sorfcu_kafa = GetComponent<CircleCollider2D>();
    }  
 
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Zemin" && sorfcu_kafa.IsTouching(other.collider))
        {
            Debug.Log("Kafasını çarptı!");
        }
    }


   /* private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag =="Zemin")
        {
            Debug.Log("kafa teması");
        }
    }
    */
}
