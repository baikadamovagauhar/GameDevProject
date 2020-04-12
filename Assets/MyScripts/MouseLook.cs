using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
	public float mouseSensetivity = 200f;
    public GameObject InventoryUI;
	public Transform playerBody;
	
	float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!InventoryUI.activeSelf)
        {
            Cursor.lockState = CursorLockMode.Locked;
            float mouseX = Input.GetAxis("Mouse X") * mouseSensetivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensetivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
        else {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
