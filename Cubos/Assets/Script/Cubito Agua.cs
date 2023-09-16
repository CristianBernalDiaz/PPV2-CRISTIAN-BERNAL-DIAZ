using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubitoAgua : Cubito
{
    public override void GetInfo()
    {
        base.GetInfo();

        Atributo = "Agua";
        Debug.Log("Cubo Atributo:" + Atributo);

        Daño = 10;
        Debug.Log("Daño: " + Daño);

        Gravedad = 5;
        Debug.Log("Gavedad:" + Gravedad);
    }

    void Start()
    {
        GetInfo();
    }
}
