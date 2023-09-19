using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_BOX_BACKGROUND : UI_BOX
{
    private Sprite BackGround;
    public Color BackGroundColor;

    void Start()
    {
        BackGround = GetComponent<Sprite>();
        //BackGroundColor = GetComponent<SpriteRenderer>().color;
    }


    void Update()
    {

    }
}
