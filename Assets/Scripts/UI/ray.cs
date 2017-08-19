using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ray : MonoBehaviour
{
    public float rayDistance = 1f;
    [SerializeField]
    GameObject bottomText;
    [SerializeField]
    GameObject mainIcon;

    private Camera _camera;
    // Use this for initialization
    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
        Ray ray = _camera.ScreenPointToRay(point);
        RaycastHit hit;
        Physics.Raycast(ray, out hit, rayDistance);
        
        if (hit.collider)
        {
            GameObject ob = hit.collider.gameObject;
            if (ob.tag == "InteractiveObject")
            {
                ob.SendMessage("showText");
                mainIcon.SendMessage("showAction");
                if(Input.GetKeyDown(KeyCode.F))
                {
                    ob.SendMessage("action"); 
                }
            }
        }
        else
        {
            bottomText.GetComponent<Text>().text = "";
            mainIcon.GetComponent<UICursorIcon>().showDefault();
        }
    }
}
