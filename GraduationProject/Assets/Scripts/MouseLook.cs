using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    float xRot = 0f;
    float yRot = 0f;
    float sensitivity = 100f;
    public GameObject player, top;
    void Start()
    {
        
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensitivity;
        xRot -= mouseY;
        yRot += mouseY;
        xRot = Mathf.Clamp(xRot, -15f, 10f);
        yRot = Mathf.Clamp(xRot, -15f, 10f);
        transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        player.transform.Rotate(Vector3.up * mouseX);
        top.transform.localRotation = Quaternion.Euler(yRot, 0, 0);
        top.transform.rotation *= Quaternion.Euler(mouseY, 0, 0);
    }
}
