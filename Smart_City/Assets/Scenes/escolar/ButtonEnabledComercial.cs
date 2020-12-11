﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnabledComercial : MonoBehaviour
{
    public GameObject contador;
    public GameObject contador2;
    public GameObject contador3;
    public GameObject text;
    public GameObject text2;
    public GameObject text3;
    public Button validar;
    public Button validar2;
    public Button validar3;

    // Start is called before the first frame update
    void Start()
    {
        contador.SetActive(false);
        contador2.SetActive(false);
        contador3.SetActive(false);
        text.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        validar.interactable = false;
        validar2.interactable = false;
        validar3.interactable = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (DropSlotComercial1.encasilla == true && DropSlotComercial2.encasilla == true && DropSlotComercial3.encasilla == true)
        {
            contador.SetActive(true);
            contador2.SetActive(true);
            contador3.SetActive(true);
            text.SetActive(true);
            text2.SetActive(true);
            text3.SetActive(true);
            validar.interactable = true;
            validar2.interactable = true;
            validar3.interactable = true;

        }
        else
        {
            contador.SetActive(false);
            contador2.SetActive(false);
            contador3.SetActive(false);
            text.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            validar.interactable = false;
            validar2.interactable = false;
            validar3.interactable = false;
        }
    }
}
