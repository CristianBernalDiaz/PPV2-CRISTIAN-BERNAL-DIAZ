using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_BOX_BACKGROUND : UI_BOX
{
    public Sprite Background;
    public Color BackgroundColor;
    void Start()
    {
        Background = GetComponent<Sprite>();
        BackgroundColor = GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
