using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightDirec : MonoBehaviour
{
    // Interpolate light color between two colors back and forth

    Light lt;
    private Color color;

    void Start()
    {
        lt = GetComponent<Light>();
        //lt.color = new Color(50, 50, 50);
    }

    void Update()
    {
        if (TemperaturaCasas.light==true)
        {
            if (ColorUtility.TryParseHtmlString("#5B5B5B", out color))
            { lt.GetComponent<Light>().color = color; }
        }
        

    }


}
