using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//for first person movement
//have camera as child of player
public class MouseCameraLook : MonoBehaviour
{
    // Start is called before the first frame update
    public float sensitivity = 100f;
    public Transform Player;
    float xRotation = 0f;
    float mouseX, mouseY;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Player.Rotate(Vector3.up * mouseX);
    }
}
