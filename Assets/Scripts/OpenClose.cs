using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClose : MonoBehaviour
{
    private enum status
    {
        open,
        close
    }
    private status current_status;
    // Use this for initialization
    void Start()
    {
        current_status = status.close;
        Animator animator = GetComponent<Animator>();
        animator.Play("open");
        //animator.StartPlayback();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}