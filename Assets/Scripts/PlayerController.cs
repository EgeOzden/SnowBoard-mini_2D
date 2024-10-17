using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float torqueAmount = 100f;
    Rigidbody2D rgb2D;

    // Start is called before the first frame update
    void Start()
    {
        rgb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Sola eğim verildi");
            rgb2D.AddTorque(torqueAmount);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Sağa eğim verildi");
            rgb2D.AddTorque(-torqueAmount);
        }
    }
}
