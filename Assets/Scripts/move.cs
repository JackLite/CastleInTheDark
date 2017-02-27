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

    public float m_Speed = 100f;

	// Use this for initialization
	void Start () {
        mainCamera = GetComponentInChildren<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
        Move();
        MouseRotate();
        if(Input.GetButtonDown("Jump"))
        {
            Rigidbody rig = GetComponent<Rigidbody>();
            rig.AddForce(0, 500, 0);
        }
    }

    private void FixedUpdate()
    {
        
    }

    void Move ()
    {
        m_MovementForBackInputValue = Input.GetAxis("Vertical");
        m_MovementLeftRightInputValue = Input.GetAxis("Horizontal");
        Rigidbody rig = GetComponent<Rigidbody>();
        Vector3 newForwardPosition = transform.forward * m_MovementForBackInputValue * Time.deltaTime * 5;
        Vector3 newRightPosition = transform.right * m_MovementLeftRightInputValue * Time.deltaTime * 5;
        rig.MovePosition(rig.position + newForwardPosition + newRightPosition);
    } 

    void MouseRotate()
    {
        m_MouseXInputValue = Input.GetAxis("Mouse Y") * Time.deltaTime;
        m_MouseYInputValue = Input.GetAxis("Mouse X") * Time.deltaTime;
        curXRotation += m_MouseXInputValue * 200;
        curYRotation += m_MouseYInputValue * 200;
        Rigidbody rig = GetComponent<Rigidbody>();
        rig.transform.rotation = Quaternion.Euler(0, curYRotation, 0);
        mainCamera.transform.localRotation = Quaternion.Euler(-curXRotation, 0, 0);
    }
}
