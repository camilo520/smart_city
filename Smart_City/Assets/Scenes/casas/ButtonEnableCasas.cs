﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnableCasas : MonoBehaviour
{
    public Button continuar;
    public Button dos;
    public Button tres;
    //public GameObject slider;
    //public GameObject signo;
    //public GameObject porcentaje;
    public GameObject tipoCaso;
    public GameObject Botones;
    public static bool cazona;

    // Start is called before the first frame update
    void Start()
    {
        continuar.interactable = false;
        dos.interactable = true;
        tres.interactable = true;
        Botones.SetActive(false);
        //slider.SetActive(false);
        //signo.SetActive(false);
        //porcentaje.SetActive(false);
        tipoCaso.SetActive(false);
        cazona = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(DropSlotCasas1.encasilla==true && DropSlotCasas2.encasilla == true && DropSlotCasas3.encasilla == true)
        {
            continuar.interactable = true;
            //slider.SetActive(true);
            //signo.SetActive(true);
            //porcentaje.SetActive(true);
            Botones.SetActive(true);
            tipoCaso.SetActive(true);
            cazona = true;
            tres.interactable = false;
        }
        else
        {
            continuar.interactable = false;
            //slider.SetActive(false);
            //signo.SetActive(false);
            //porcentaje.SetActive(false);
            tipoCaso.SetActive(false);
            Botones.SetActive(false);
            cazona = false;
            tres.interactable = true;
        }

        if (MenuPrincipal.finCasa == true)
        {
            continuar.interactable = false;
            dos.interactable = false;
            tres.interactable = false;
        }

    }

}
