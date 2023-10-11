using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaFuego : EspadaBase
{
    public override void GetInfo()
    {
        base.GetInfo();

        Name = "Espada";
        Debug.Log("Name" + Name);

        Atributo = "Fuego";
        Debug.Log("Atributo" + Atributo);

        Daño = 50;
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
