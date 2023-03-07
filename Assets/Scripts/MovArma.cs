using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class MovArma : MonoBehaviour
{
    public float velocidadeRotacao;
    private float rotacaoVertical;
  
    // Update is called once per frame
    void Update()
    {
        rotacaoVertical += Input.GetAxis("Mouse Y") * velocidadeRotacao;
        float rotacaoX = Mathf.Clamp(-rotacaoVertical, -45, 45);
        transform.localEulerAngles = new Vector3(rotacaoX, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
}
