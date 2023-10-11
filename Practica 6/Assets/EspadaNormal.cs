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

        Daño = 20;
        Debug.Log("Daño" + Daño);


    }
    void Start()
    {
        GetInfo();
    }

    
    void Update()
    {
        
    }
}
