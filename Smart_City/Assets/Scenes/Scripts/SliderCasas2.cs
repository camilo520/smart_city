﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderCasas2 : MonoBehaviour
{
    public static int porc;
    Text porcentaje;
    // Start is called before the first frame update
    void Start()
    {
        porcentaje = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void actualizacionTexto(float value)
    {
        porcentaje.text = Mathf.RoundToInt(value * 40) + "";
        int otro = 0;
        if (Int32.TryParse(porcentaje.text, out otro))
        {
            porc = otro;
            Debug.Log("Temperatura: " + porc);
        }

    }
}