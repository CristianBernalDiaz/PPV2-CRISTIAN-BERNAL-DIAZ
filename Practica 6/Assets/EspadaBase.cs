using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaBase : MonoBehaviour
{
    public string Name;
    public string Atributo;
    public int Daño;

    public virtual void GetInfo()
    {
        Debug.Log("Name" + Name);
        Debug.Log("Atributo" + Atributo);
        Debug.Log("Daño" + Daño);
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
