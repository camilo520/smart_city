﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ComprobarApartamentos : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void comprobar()
    {
        if (SliderCasas1.porc >= 40 && SliderCasas1.porc <= 55)
        {
            Debug.Log("Sisas");
            panel.SetActive(true);
        }

        else
        {
            Debug.Log("Nonas");
            panel.SetActive(false);
        }
    }
    }
