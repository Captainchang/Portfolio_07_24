using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    public GameObject Titleobj;
    void Start()
    {
        Invoke("hide", 1.5f);
    }
    void hide()
    {
        Titleobj.SetActive(false);
    }

}
