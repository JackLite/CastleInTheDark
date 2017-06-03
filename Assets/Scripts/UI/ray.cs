using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour
{
    public float rayDistance = 1f;

    private Camera _camera;
    private GameObject mainIcon;
    // Use this for initialization
    void Start()
    {
        _camera = GetComponent<Camera>();
        mainIcon = GameObject.Find("mainIcon");
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
            ob.SendMessage("showName");
            mainIcon.SendMessage("showAction");
        }
        else
        {
            bottomText.changeText("");
            mainIcon.SendMessage("showDefault");
        }
    }
}
