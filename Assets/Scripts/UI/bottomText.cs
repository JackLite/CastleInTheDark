using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bottomText { 
    public static void changeText(string newText)
    {
        GameObject bText = GameObject.Find("BottomText");
        Text text = (Text) bText.GetComponent("Text");
        text.text = newText;
    }
}
