using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPref;
    
    void Start()
    {
        PhotonNetwork.Instantiate(playerPref.name, new Vector3(0.0f, 1.0f, 0.0f), Quaternion.identity);
    }

    
    void Update()
    {
        
    }
}
