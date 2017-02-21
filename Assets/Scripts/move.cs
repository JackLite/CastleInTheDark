using UnityEngine;
using System.Collections;
using System;

public class move : MonoBehaviour {

    private float m_MovementInputValue;
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

    }

    private void FixedUpdate()
    {
        
    }

    void Move ()
    {
        m_MovementInputValue = Input.GetAxis("Vertical");
        
        Rigidbody rig = GetComponent<Rigidbody>();
        Vector3 newPosition = transform.forward * m_MovementInputValue * Time.deltaTime;
        rig.MovePosition(rig.position + newPosition);
    } 

    void MouseRotate()
    {
        m_MouseXInputValue = Input.GetAxis("Mouse Y") * Time.deltaTime;
        m_MouseYInputValue = Input.GetAxis("Mouse X") * Time.deltaTime;
        curXRotation += m_MouseXInputValue * 20;
        curYRotation += m_MouseYInputValue * 20;
        Rigidbody rig = GetComponent<Rigidbody>();
        rig.transform.rotation = Quaternion.Euler(0, curYRotation, 0);
        mainCamera.transform.localRotation = Quaternion.Euler(-curXRotation, 0, 0);
    }
}
