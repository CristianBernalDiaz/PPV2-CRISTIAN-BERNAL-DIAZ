using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_BOX : MonoBehaviour
{
    protected UI_BOX_BACKGROUND BoxBackGround;
    protected UI_BOX_HEADER BoxHeader;
    protected UI_BOX_HEADER_TITLE BoxHeaderTitle;
    protected UI_BACKGROUND_CONTAINER_TITLE BoxContent;

    public string Title = "";
    public string Content = "";
    public bool hasCloseButton = true;
    void Start()
    {
        BoxHeaderTitle = transform.GetChild(0).transform.GetChild(0).GetComponent<UI_BOX_HEADER_TITLE>();
        BoxBackGround = transform.GetChild(0).GetComponent<UI_BOX_BACKGROUND>();
        BoxHeader = transform.GetChild(0).transform.GetChild(0).GetComponent<UI_BOX_HEADER>();
        BoxContent = transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).GetComponent<UI_BACKGROUND_CONTAINER_TITLE>();
        BoxHeaderTitle.Title = Title;
        BoxContent.Content.text = Content;

        transform.GetChild(0).transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(hasCloseButton);
    }
    private void Update()
    {
        
    }
}
