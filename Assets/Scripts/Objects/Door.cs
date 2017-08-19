using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public string openText = "Открыть";
    public string closeText = "Закрыть";

    public enum status
    {
        open,
        close
    }
    public status currentStatus = status.close;

    public void showText()
    {
        if (currentStatus == status.open)
        {
            bottomText.changeText(closeText);
        }
        else
        {
            bottomText.changeText(openText);
        }
    }

    public void action()
    {
        Animator anim = GetComponent<Animator>();
        if(anim.GetBool("isAnimate"))
        {
            return;
        }
        if (currentStatus == status.open)
        {
            DoorController.closeDoor(gameObject);
            currentStatus = status.close;
        }
        else
        {
            DoorController.openDoor(gameObject);
            currentStatus = status.open;
        }
    }
}
