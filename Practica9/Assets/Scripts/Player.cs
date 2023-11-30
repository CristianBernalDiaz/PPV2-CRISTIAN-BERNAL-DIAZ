using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player : MonoBehaviour
{
    private PhotonView vew;
    public float speed;

    void Start()
    {
        vew = GetComponent<PhotonView>();
    }

    
    void Update()
    {
       if (vew.IsMine)
        {
            Vector3 movementInput = Vector3.zero;
            if (Input.GetKey(KeyCode.D))
            {
                movementInput.x = 1;
            }
            if (Input.GetKey(KeyCode.A))
            {
                movementInput.x = -1;
            }
            if (Input.GetKey(KeyCode.W))
            {
                movementInput.z = 1;
            }
            if (Input.GetKey(KeyCode.S))
            {
                movementInput.z = -1;
            }
            Move(movementInput);
        } 
    }
    void Move(Vector3 dir)
    {
        transform.position += dir.normalized * speed * Time.deltaTime;
            
    }
}
