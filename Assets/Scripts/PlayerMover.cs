using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {

    public float moveSpeed;
    public float rotateSpeed;
    public float mouseSensitivity;

    private Rigidbody playerRB;

	void Start () {
        playerRB = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
	}
	
	void FixedUpdate () {
        //takes player input.
        float moveX = Input.GetAxis("X-axis");
        float moveY = Input.GetAxis("Y-Axis");
        float moveZ = Input.GetAxis("Z-axis");

        float rotateX = Input.GetAxis("Mouse Y") * mouseSensitivity;
        float rotateY = Input.GetAxis("Mouse X") * mouseSensitivity;
        float rotateZ = Input.GetAxis("Z-rotaxis");

        //sets vector3s from input to give to the player oject
        Vector3 movement = new Vector3(moveX, moveY, moveZ);
        Vector3 rotation = new Vector3(rotateX,rotateY,rotateZ);

        //makes player object move
        playerRB.AddRelativeForce(movement * moveSpeed);
        gameObject.transform.Rotate(rotation);

    }
}
