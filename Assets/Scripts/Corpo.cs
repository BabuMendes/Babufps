using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Corpo : MonoBehaviour
{
    private Rigidbody Rb;
    private Animator Anim;
    public float sensibilidade;
    private float velocidadeP;

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
        //Correr
        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocidadeP = 12;
        }
        else
        {
            velocidadeP = 5;
        }

        //Movimento Andar
        float velZ = Input.GetAxis("Vertical") * 2;
        float velX = Input.GetAxis("Horizontal") * 2;
        //PosCorrigida
        Vector3 velCorrigida = velX* transform.right + velZ * transform.forward;

        Rb.velocity = new Vector3(velCorrigida.x, Rb.velocity.y, velCorrigida.z);

        if(velX != 0 || velZ !=0)
        {
            Anim.SetBool("Andar", true);
        }
        else if(velX == 0 && velZ == 0)
        {
            Anim.SetBool("Andar", false);
        }

        //Movimento Girar
        float mouseX = Input.GetAxis("Mouse X") * sensibilidade * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseX);



    }
}
