using UnityEngine;
using System.Collections;
using System;

public class move : MonoBehaviour {

    private Vector3 moveDirection;
    private float m_MouseXInputValue;
    private float m_MouseYInputValue;
    private float curXRotation;
    private float curYRotation;
    private Camera mainCamera;
    private Rigidbody rig;
    private CharacterController character; 

    public float m_Speed = 100f;

	// Use this for initialization
	void Start () {
        mainCamera = GetComponentInChildren<Camera>();
        character = GetComponent<CharacterController>();
        character.transform.rotation = Quaternion.Euler(0, 180, 0);
    }
	
	// Update is called once per frame
	void Update () {
        Move();
        MouseRotate();
    }

    private void FixedUpdate()
    {
        
    }

    void Move ()
    {

        if (character.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= m_Speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = 7;

        }
        moveDirection.y -= 20 * Time.deltaTime;
        character.Move(moveDirection * Time.deltaTime);
    }

    void MouseRotate()
    {
        m_MouseXInputValue = Input.GetAxis("Mouse Y") * Time.deltaTime;
        m_MouseYInputValue = Input.GetAxis("Mouse X") * Time.deltaTime;
        curXRotation += m_MouseXInputValue * 200;
        curYRotation += m_MouseYInputValue * 200;
        if (curXRotation >= 90)
            curXRotation = 90;
        else if (curXRotation <= -90)
            curXRotation = -90;
        character.transform.rotation = Quaternion.Euler(0, curYRotation, 0);
        mainCamera.transform.localRotation = Quaternion.Euler(-curXRotation, 0, 0);
    }
}
