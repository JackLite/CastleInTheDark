using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectsName : MonoBehaviour, IInteractivable {
    [SerializeField]
    GameObject SceneController;

    private UIController controller;

    public string objectName = "Введите название объекта";

    public void Start()
    {
        controller = SceneController.GetComponent<UIController>();
    }

    private string getName()
    {
        return objectName;
    }
    public void showText()
    {
        controller.changeText(objectName);
    }
}
