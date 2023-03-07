using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_arma : MonoBehaviour
{

    public TMP_Text meuTexto;
    private Atirarama minhaArma;
    void Start()
    {
        minhaArma = GameObject.FindGameObjectWithTag("Arma").GetComponent<Atirarama>();
    }

    void Update()
    {
        meuTexto.text = "Arma: " + minhaArma.municao.ToString() + " / " + minhaArma.limiteMunicao.ToString();
    }
}