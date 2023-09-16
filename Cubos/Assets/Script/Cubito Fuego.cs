using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubitoFuego : Cubito
{
    public override void GetInfo()
    {
        base.GetInfo();

        Atributo = "Fuego";
        Debug.Log("Cubo Atributo:" + Atributo);

        Da�o = 20;
        Debug.Log("Da�o: " + Da�o);

        Gravedad = 3;
        Debug.Log("Gavedad:" + Gravedad);
    }

    void Start()
    {
        GetInfo();
    }
}
