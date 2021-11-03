using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementController : MonoBehaviour
{
    GameObject Player;
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = .66f;
    private float rotationSpeed = 100f;
    private float playerRunSpeed = 1.33f;
    private float jumpHeight = .33f;
    private float gravityValue = -6.81f;

    private void Start()
    {
        //controller = this.parent.gameobject.getComponent<CharacterController>();
        Player = GameObject.Find("Player");
        controller = gameObject.GetComponent<CharacterController>();
        //gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        //Jump
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        if (Input.GetKey(KeyCode.Space) && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        //Gravity
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        //Left and Right
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            Vector3 move = Vector3.zero;
            if (Input.GetKey(KeyCode.A))
            {
                move = Player.transform.rotation * Vector3.left;
            }
            else
            {
                move = Player.transform.rotation * Vector3.right;
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                controller.Move(move * Time.deltaTime * playerRunSpeed);
            }
            else
            {
                controller.Move(move * Time.deltaTime * playerSpeed);
            }
        }
        // Forward and back
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            Vector3 move = Vector3.zero;
            if (Input.GetKey(KeyCode.W))
            {
                move = Player.transform.rotation * Vector3.forward;
            }
            else
            {
                move = Player.transform.rotation * Vector3.back;
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                controller.Move(move * Time.deltaTime * playerRunSpeed);
            }
            else
            {
                controller.Move(move * Time.deltaTime * playerSpeed);
            }
        }

        //Mouse look left and right
        if(Input.GetMouseButton(1))
        {
            Vector3 rotation = new Vector3(0f, Input.GetAxis("Mouse X") * rotationSpeed * 10 * Time.deltaTime, 0f);
            Player.transform.Rotate(rotation);
            //Debug.Log(rotation.ToString());
        }
    }
}