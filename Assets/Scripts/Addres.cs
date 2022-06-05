using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Addres : MonoBehaviour
{
    public string nameAddres;
    public bool isClosed;
    
    private TextMeshPro _text;
    
    void Start()
    {
        _text = GetComponentInChildren<TextMeshPro>();
    }

  
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (isClosed)
        {
            _text.color = Color.green;
            isClosed = false;
        }
        else
        {
            _text.color = Color.red;
            isClosed = true;
            Debug.Log("Жмакнули по " + nameAddres);
        }
    }
}
