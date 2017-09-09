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
    GameObject MainIcon;
    [SerializeField]
    GameObject SceneController;

    private Camera _camera;
    private UIController _controller;
    // Use this for initialization
    void Start()
    {
        _camera = GetComponent<Camera>();
        _controller = SceneController.GetComponent<UIController>();
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
            IInteractivable interactiveObject = ob.GetComponent<IInteractivable>();
            if(interactiveObject is IInteractivable)
            {
                interactiveObject.showText();
                if (interactiveObject is IActionable)
                {
                    IActionable actionObject = interactiveObject as IActionable;
                    MainIcon.GetComponent<UICursorIcon>().showAction();
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        actionObject.doAction();
                    }
                }
            }
            
        }
        else
        {
            _controller.changeText("");
            MainIcon.GetComponent<UICursorIcon>().showDefault();
        }
    }
}
