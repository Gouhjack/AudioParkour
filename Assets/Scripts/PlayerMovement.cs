using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }










void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 direction = transform.right * horizontalInput + transform.forward * verticalInput;
        Vector3 move = direction * _speed * Time.deltaTime;

        _characterController.Move(move);


    }





    private CharacterController _characterController;

}