using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaNormal : EspadaBase
{
    public override void GetInfo()
    {
        base.GetInfo();

        Name = "Espada";
        Debug.Log("Name" + Name);

        Atributo = "Normal";
        Debug.Log("Atributo" + Atributo);

        Da�o = 20;
        Debug.Log("Da�o" + Da�o);


    }
    void Start()
    {
        GetInfo();
    }

    
    void Update()
    {
        
    }
}
