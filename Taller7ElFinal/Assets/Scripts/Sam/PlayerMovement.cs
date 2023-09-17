using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float xrot;

    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
     private Vector2 mouseMovement;
     private Vector3 PlayerMovementInput;
    [SerializeField] private float sensitivity;


    [Space]
    [SerializeField] private Transform PlayerCamera;
    [SerializeField] private Rigidbody rb;



    // Update is called once per frame
    void Update()
    {

        mouseMovement = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        MovePlayer();
        MoveCamera(); 
    }

    void MovePlayer ()
    {
        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * speed;
        rb.velocity = new Vector3(MoveVector.x,rb.velocity.y, MoveVector.z);
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    void MoveCamera()
    {
        xrot -= mouseMovement.y*sensitivity;
        transform.Rotate(0f, mouseMovement.x * sensitivity, 0f);
        PlayerCamera.transform.localRotation = Quaternion.Euler(xrot,0,0);
    }
}
