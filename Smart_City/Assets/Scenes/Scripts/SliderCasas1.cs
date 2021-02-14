using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderCasas1 : MonoBehaviour
{
    public static int porc;
    public AudioSource audio;
    Text porcentaje;
    // Start is called before the first frame update
    void Start()
    {
        porcentaje = GetComponent<Text>();
        porc = 80;
    }

    // Update is called once per frame
    void Update()
    {
        if (porc >= 66)
        {
            audio.volume = 0.6f;
        }
        else
        {
            audio.volume = 0.3f;
        }
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

