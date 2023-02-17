using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corpo : MonoBehaviour
{
    private Rigidbody Rb;
    private Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        Anim = GetComponent<Animator>();
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

        if(velX != 0 || velZ !=0)
        {
            Anim.SetBool("Andar", true);
        }
        else if(velX == 0 && velZ == 0)
        {
            Anim.SetBool("Andar", false);
        }
    }
}
