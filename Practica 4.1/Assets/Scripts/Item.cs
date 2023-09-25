using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Item_Effect
{
    NONE = 0,
    CONSUMIBLE = 1,
    DAMAGE = 2
}

public class Item : MonoBehaviour
{
    public string Name;
    public Sprite Image;
    public Item_Effect Effect;
   
    public Item() { }
    public Item(string _name)
    {
        Name = _name;
        Image = GetComponent<Sprite>();
        Effect = Item_Effect.NONE;
    }

    public Item(string _name, Sprite _image, Item_Effect _effec)
    {
        Name = _name;
        name = _name;
        Image = _image;
        _effec = Effect;
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
