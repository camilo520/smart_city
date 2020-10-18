using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class texto_aparecer : MonoBehaviour
{
    public Text textoO;
    private float time = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ocultar();
    }

    void ocultar()
    {
        if (Input.GetKey(KeyCode.Space))
        {
                textoO.enabled = false;

            
        }
    }


}
