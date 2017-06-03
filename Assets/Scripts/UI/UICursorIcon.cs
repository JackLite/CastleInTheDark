using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICursorIcon : MonoBehaviour
{
    public Sprite defaultIcon;
    public Sprite actionIcon;
    public Sprite lookIcon;

    public float widthDefault;
    public float heightDefalut;
    public float widthAction;
    public float heightAction;
    public float widthLook;
    public float heightLook;

    // Use this for initialization
    void Start()
    {
        Image img = GetComponent<Image>();
        img.sprite = defaultIcon;
        img.SetNativeSize();
    }

    public void showDefault()
    {
        setSprite(defaultIcon);
    }
    public void showAction()
    {
        setSprite(actionIcon, widthAction, heightAction);
    }
    public void showLook()
    {
        setSprite(lookIcon, widthLook, heightLook);
    }

    private void setSprite(Sprite icon)
    {
        GameObject gameObj = GameObject.Find("mainIcon");
        Image img = gameObj.GetComponent<Image>();
        img.sprite = icon;
        img.SetNativeSize();
    }
    private void setSprite(Sprite icon, float width, float height)
    {
        Image img = getImg();
        img.sprite = icon;
        RectTransform transform = img.GetComponent<RectTransform>();
        transform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
        transform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
    }
    private Image getImg()
    {
        GameObject gameObj = GameObject.Find("mainIcon");
        return gameObj.GetComponent<Image>();
    }

}
