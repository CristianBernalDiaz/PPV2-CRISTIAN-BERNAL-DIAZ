using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public string Name = "Enemy";
    public int Health = 100;
    public List<string> Loot;

    public virtual void Init()
    {
        Loot = new List<string>();
    }

    public virtual void AddLoot(string Item)
    {
        Loot.Add(Item);
    }

    public virtual List<string> GetLoot()
    {
        return Loot;
    }

    public virtual int GetHealth()
    {
        return Health;
    }
}
