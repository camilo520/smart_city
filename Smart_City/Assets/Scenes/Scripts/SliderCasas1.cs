using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderCasas1 : MonoBehaviour
{
    public static int porc=80;
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
        porcentaje.text = Mathf.RoundToInt(value) + "";
        int otro = 0;
        if (Int32.TryParse(porcentaje.text, out otro))
        {
            porc = otro;
            Debug.Log("Humedad: " + porc);
        }

    }

}

