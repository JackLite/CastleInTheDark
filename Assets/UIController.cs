using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    [SerializeField]
    GameObject bottomText;
    [SerializeField]
    GameObject mainIcon;
	
    public void changeText(string newText)
    {
        bottomText.GetComponent<Text>().text = newText;
    }
}
