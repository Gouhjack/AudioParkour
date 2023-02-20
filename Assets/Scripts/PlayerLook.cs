using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private Vector2 _mouseSensitivity;
    [SerializeField] private Vector2 _padSensitivity;
    [SerializeField] private Vector2 _mouseYLimit;
    [SerializeField] private Transform _cameraTransform;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }



    void Start()
    {
        
    }

    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        mouseX = mouseX * _mouseSensitivity.x * Time.deltaTime;
        mouseY = mouseY * _mouseSensitivity.y * Time.deltaTime;

       // gamePadX = Input.GetAxis("RightHorizontal") * _padSensitivity.x * Time.deltaTime;
       // gamePadY = Input.GetAxis("RightVertical") * _padSensitivity.y * Time.deltaTime;

        _horizontal += mouseX + gamePadX;
        _vertical += mouseY + gamePadY;
        _vertical = Mathf.Clamp(_vertical, _mouseYLimit.x, _mouseYLimit.y);

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, _horizontal, transform.eulerAngles.z);
        _cameraTransform.eulerAngles = new Vector3(_vertical, _cameraTransform.eulerAngles.y, _cameraTransform.eulerAngles.z);

        

    }





    private float _horizontal;
    private float _vertical;
    private float gamePadX;
    private float gamePadY;
    

}
