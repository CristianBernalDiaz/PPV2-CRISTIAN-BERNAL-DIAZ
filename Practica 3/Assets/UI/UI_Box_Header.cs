using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Box_Header : UI_Box_BackGround
{
    private Sprite Header;
    public Color HeaderColor;

    void Start()
    {
        Header = GetComponent<Sprite>();
        //HeaderColor = GetComponent<SpriteRenderer>().color; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
