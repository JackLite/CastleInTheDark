using UnityEngine;
using System.Collections;
using System;

public class move : MonoBehaviour {

    private float m_MovementForBackInputValue;
    private float m_MovementLeftRightInputValue;
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
    }
	
	// Update is called once per frame
	void Update () {
        Move();
        MouseRotate();
        if(Input.GetButtonDown("Jump"))
        {
            //rig.AddForce(0, 500, 0);
            //rig.AddForce(0, 500, 0);
        }
    }

    private void FixedUpdate()
    {
        
    }

    void Move ()
    {

        m_MovementForBackInputValue = Input.GetAxis("Horizontal") * Time.deltaTime * 5;
        m_MovementLeftRightInputValue = Input.GetAxis("Vertical") * Time.deltaTime * 5;
        Vector3 movement = new Vector3(m_MovementForBackInputValue, -5, m_MovementLeftRightInputValue);
        movement = transform.TransformDirection(movement);
        character.Move(movement);
    } 

    void MouseRotate()
    {
        m_MouseXInputValue = Input.GetAxis("Mouse Y") * Time.deltaTime;
        m_MouseYInputValue = Input.GetAxis("Mouse X") * Time.deltaTime;
        curXRotation += m_MouseXInputValue * 200;
        curYRotation += m_MouseYInputValue * 200;
        character.transform.rotation = Quaternion.Euler(0, curYRotation, 0);
        mainCamera.transform.localRotation = Quaternion.Euler(-curXRotation, 0, 0);
    }
}
