using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubito : MonoBehaviour
{
    public string Name = "Cubo";
    public string Atributo = "Normal";
    public int Da�o = 0;
    public float Gravedad = 0f;

    public virtual void GetInfo()

    {
        Debug.Log("Name: " + Name);
        Debug.Log("Atributo: " + Atributo);
        Debug.Log("Da�o : " + Da�o);
        Debug.Log("Gravedad :" + Gravedad);
    }
}
