using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aldeano : Person

{
    public override void GetInfo()
    {
        base.GetInfo();
        id = 123;
        Debug.Log("Aldeano ID: " + id);
    }
    private void Start()
    {
        GetInfo();
    }
}
