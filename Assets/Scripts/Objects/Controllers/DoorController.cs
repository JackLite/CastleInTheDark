using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DoorController {

    public static void openDoor(GameObject door)
    {
        Animator animator = door.GetComponent<Animator>();
        animator.Play("open");

    }
	public static void closeDoor(GameObject door)
    {
        Animator animator = door.GetComponent<Animator>();
        animator.Play("close");
    }
}
