using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaBase : MonoBehaviour
{
    public string Name;
    public string Atributo;
    public int Da�o;

    public virtual void GetInfo()
    {
        Debug.Log("Name" + Name);
        Debug.Log("Atributo" + Atributo);
        Debug.Log("Da�o" + Da�o);
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
