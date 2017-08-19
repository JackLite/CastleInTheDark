using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DoorController {

    public static void openDoor(GameObject door)
    {
        Animator animator = door.GetComponent<Animator>();
        animator.SetBool("isAnimate", true);
        animator.SetBool("open", true);

    }
	public static void closeDoor(GameObject door)
    {
        Animator animator = door.GetComponent<Animator>();
        animator.SetBool("isAnimate", true);
        animator.SetBool("close", true);
    }
}
