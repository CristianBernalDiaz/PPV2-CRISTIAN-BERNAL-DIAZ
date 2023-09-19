using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UI_BOX_HEADER_TITLE : UI_BOX_HEADER
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
