using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviour
{
    public InputField createInput;
    public InputField joinInput;
   
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInput.text);
    }
    public void JointeRoom()
    {
        PhotonNetwork.JoinRoom(createInput.text);
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
