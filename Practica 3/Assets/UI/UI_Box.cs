using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Box : MonoBehaviour
{
    public UI_Header_Title BoxHeaderTitle;


    public string Title = "";
    public string Content = "";
    void Start()
    {
        BoxHeaderTitle.Title.text = Title;
    }

    
    void Update()
    {
        
    }
}
