using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Header_Title : UI_Box_Header
{
    public TMP_Text title;

    void Start()
    {
        title = GetComponent<TMP_Text>();
    }

   
    void Update()
    {
        
    }
}
