using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Box_BackGround : UI_Box
{
    private Sprite BackGround;
    public Color BackGroundColor;

    void Start()
    {
        BackGround = GetComponent<Sprite>();
        BackGroundColor = GetComponent<SpriteRenderer>().color;
    }

    
    void Update()
    {

    }
}
