using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_BOX : MonoBehaviour
{
    public UI_BOX_HEADER_TITLE BoxHeaderTitle;

    [SerializeField]
    public string Title = "";
    [SerializeField]
    public string Content = "";

    void Start()
    {
        BoxHeaderTitle = transform.GetChild(0).transform.GetChild(0).GetComponent<UI_BOX_HEADER_TITLE>();
        BoxHeaderTitle.title.text = Title;
          
    }

    void Update()
    {

    }
}
