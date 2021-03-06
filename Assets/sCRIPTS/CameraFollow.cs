﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//For Third person movement 
//have child of an empty object that is a child of the player
public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public float RoationSpeed = 1f;
    public Transform Target;
    public Transform Player;

    float mouseX, mouseY;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        mouseY += Mathf.Clamp(Input.GetAxis("Mouse Y") * RoationSpeed, -35, 60);
        mouseX += Input.GetAxis("Mouse X") * RoationSpeed;

        //transform.LookAt(Target);
        transform.LookAt(Player.forward);

        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Player.rotation = Quaternion.Euler(0, mouseX, 0);

    }
}
