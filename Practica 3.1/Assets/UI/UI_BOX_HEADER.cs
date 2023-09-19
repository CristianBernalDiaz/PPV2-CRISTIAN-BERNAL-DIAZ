using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_BOX_HEADER : UI_BOX_BACKGROUND
{
    private Sprite Header;
    public Color HeaderColor;

    void Start()
    {
        Header = GetComponent<Sprite>();
        //HeaderColor = GetComponent<SpriteRenderer>().color;
    }

    
    void Update()
    {
        
    }
}
