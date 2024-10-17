using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FinishLine : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Sorfcu"){
            Debug.Log("Finish!!! :)");    
        }

    }
}
