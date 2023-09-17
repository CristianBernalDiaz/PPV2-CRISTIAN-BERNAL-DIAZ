using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Box_Header : UI_Box_BackGround
{
    private Sprite header;
    public Color headerColor;

    void Start()
    {
        header = GetComponent<Sprite>();
        //headerColor = GetComponent<SpriteRenderer>().color; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
