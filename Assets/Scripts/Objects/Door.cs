using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IActionable
{
    [SerializeField]
    GameObject SceneController;
    private UIController controller;

    public string openText = "Открыть";
    public string closeText = "Закрыть";

    public enum status
    {
        open,
        close
    }
    public status currentStatus = status.close;

    public void Start()
    {
        controller = SceneController.GetComponent<UIController>();
    }

    public void showText()
    {
        if (currentStatus == status.open)
        {
            controller.changeText(closeText);
        }
        else
        {
            controller.changeText(openText);
        }
    }

    public void doAction()
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
