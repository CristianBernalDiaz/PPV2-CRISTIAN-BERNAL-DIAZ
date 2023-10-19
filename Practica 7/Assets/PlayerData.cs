using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerData 
{
    public string Name;
    public string Description;
    public string[] Data;
    public int Id;
    public PlayerData(string _name, string _desciption, int _id)
    {
        Name = _name;
        Description = _desciption;
        Id = _id;
    }
}
