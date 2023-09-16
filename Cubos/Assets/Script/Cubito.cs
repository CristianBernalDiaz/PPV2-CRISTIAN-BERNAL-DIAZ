using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubito : MonoBehaviour
{
    public string Name = "Cubo";
    public string Atributo = "Normal";
    public int Daño = 0;
    public float Gravedad = 0f;

    public virtual void GetInfo()

    {
        Debug.Log("Name: " + Name);
        Debug.Log("Atributo: " + Atributo);
        Debug.Log("Daño : " + Daño);
        Debug.Log("Gravedad :" + Gravedad);
    }
}
