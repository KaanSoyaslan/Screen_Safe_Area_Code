using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeArea : MonoBehaviour
{
    
    RectTransform rectTransform;
    Rect safeArea;
    Vector2 minAnchor;
    Vector2 maxAnchor;


    void Awake()
    {
        SafeAreaCalculate();
    }
    void Update()
    {
        //flipPhone tarz� cihazlarda anl�k katlama a�ma i�in
        //sabit ekranl� cihazlar i�in bu k�s�m �art de�il!

        //For foldable screen devices
        //Not need for normal screen devices
        SafeAreaCalculate();
        //
    }
    public void SafeAreaCalculate()
    {
        rectTransform = GetComponent<RectTransform>();
        safeArea = Screen.safeArea;
        minAnchor = safeArea.position; //min �apam�z� belirledik  //min anch 
        maxAnchor = minAnchor + safeArea.size;

        minAnchor.x /= Screen.width;
        minAnchor.y /= Screen.height;
        maxAnchor.x /= Screen.width;
        maxAnchor.y /= Screen.height;
        //yeni �apa de�erlerimizi bulduk
        //caculated new anch values


        //yeni �apa de�erlerimizi ana ekran�m�za e�itledik   //safe area  
        rectTransform.anchorMin = minAnchor;
        rectTransform.anchorMax = maxAnchor;
    }
}
