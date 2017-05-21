using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crossHair : MonoBehaviour
{



    //текстура прицела

    public Texture2D crossHairTexture;

    private Rect crossHairPosition;



    

    void Start()
    {

        //вычисляем положение текстуры прицела, так чтобы он был по центру

        //монитора

        crossHairPosition = new Rect((Screen.width - crossHairTexture.width) / 2,

                                     (Screen.height - crossHairTexture.height) / 2,

                                     crossHairTexture.width, crossHairTexture.height);

    }



    void OnGUI()
    {

        //прорисуем текстуру прицела

        GUI.DrawTexture(crossHairPosition, crossHairTexture);

    }

}