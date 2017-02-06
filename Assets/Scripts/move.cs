using UnityEngine;
using System.Collections;
using System;

public class move : MonoBehaviour {

    private float m_MovementInputValue;

    public float m_Speed = 100f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        m_MovementInputValue = Input.GetAxis("Vertical");
        
        Rigidbody rig = GetComponent<Rigidbody>();
        Vector3 newPosition = transform.forward * 100 * m_MovementInputValue * Time.deltaTime;
        if (m_MovementInputValue > 0)
        {
            Debug.Log(newPosition.x);
            Debug.Log(newPosition.y);
            Debug.Log(newPosition.z);
        }
        rig.MovePosition(rig.position + newPosition);
    }

    void Move ()
    {

    } 
}
