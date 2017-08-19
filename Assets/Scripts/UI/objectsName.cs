using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectsName : MonoBehaviour {
    public string objectName = "Введите название объекта";

    private string getName()
    {
        return objectName;
    }
    public void showText()
    {
        bottomText.changeText(objectName);
    }
}
