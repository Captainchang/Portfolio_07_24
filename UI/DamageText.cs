using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class DamageText : MonoBehaviour
{
    public TextMeshPro damageText;
    public float moveSpeed = 2.0f;
    public float fadeSpeed = 2.0f;

    private void Start()
    {
        //damageText.text = damageText.ToString();
        Destroy(gameObject, 1.0f); 
    }

    private void Update()
    {
        
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        // Fade out the text
    //    Color textColor = damageText.color;
     //   textColor.a -= fadeSpeed * Time.deltaTime;
     //   damageText.color = textColor;
    }
}
