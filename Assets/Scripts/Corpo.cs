using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corpo : MonoBehaviour
{
    private Rigidbody Rb; 
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }


    void Mover() 
    {

        float velZ = Input.GetAxis("Vertical");
        float velX = Input.GetAxis("Horizontal");
        Rb.velocity = new Vector3(velX, Rb.velocity.y, velZ);
    }
}
