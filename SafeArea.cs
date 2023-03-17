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
        //flipPhone tarzý cihazlarda anlýk katlama açma için
        //sabit ekranlý cihazlar için bu kýsým þart deðil!

        //For foldable screen devices
        //Not need for normal screen devices
        SafeAreaCalculate();
        //
    }
    public void SafeAreaCalculate()
    {
        rectTransform = GetComponent<RectTransform>();
        safeArea = Screen.safeArea;
        minAnchor = safeArea.position; //min çapamýzý belirledik  //min anch 
        maxAnchor = minAnchor + safeArea.size;

        minAnchor.x /= Screen.width;
        minAnchor.y /= Screen.height;
        maxAnchor.x /= Screen.width;
        maxAnchor.y /= Screen.height;
        //yeni çapa deðerlerimizi bulduk
        //caculated new anch values


        //yeni çapa deðerlerimizi ana ekranýmýza eþitledik   //safe area  
        rectTransform.anchorMin = minAnchor;
        rectTransform.anchorMax = maxAnchor;
    }
}
