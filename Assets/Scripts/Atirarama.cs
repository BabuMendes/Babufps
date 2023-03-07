using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Atirarama : MonoBehaviour
{
    public GameObject PontoDeSaida;
    public GameObject Bala;
    public int limiteMunicao = 30;
    public int municao = 30;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (municao > 0)
            {
                municao--;
                GameObject Disparo = Instantiate(Bala, PontoDeSaida.transform.position, Quaternion.identity);
                Disparo.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                Destroy(Disparo, 2f);
            }
        }
    }


    public void Carregar()
    {
        municao = municao + 10;
        if(municao > 30)
        {
            municao = 30;
        }
    }
}