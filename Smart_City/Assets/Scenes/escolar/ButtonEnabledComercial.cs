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
    public GameObject slider1;
    public GameObject slider2;
    public GameObject slider3;
    public Button validar;
    public Button validar2;
    public Button validar3;
    public Button dos;
    public Button tres;
    public GameObject panel;
    public GameObject textoIN;
    private bool playAudio = false;
    public static AudioClip clipCorrecto;
    public AudioSource audiosrc;


    // Start is called before the first frame update
    void Start()
    {
        contador.SetActive(false);
        contador2.SetActive(false);
        contador3.SetActive(false);
        text.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        playAudio = false;
        validar.interactable = false;
        validar2.interactable = false;
        validar3.interactable = false;
        dos.interactable = true;
        tres.interactable = true;
        slider1.SetActive(false);
        slider2.SetActive(false);
        slider3.SetActive(false);
        textoIN.SetActive(false);
        clipCorrecto = Resources.Load<AudioClip>("succes_sound2");
        audiosrc.GetComponent<AudioSource>();

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
            slider1.SetActive(true);
            slider2.SetActive(true);
            slider3.SetActive(true);
            textoIN.SetActive(true);
            tres.interactable = false;

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
            slider1.SetActive(false);
            slider2.SetActive(false);
            slider3.SetActive(false);
            textoIN.SetActive(false);
            tres.interactable = true;
        }

        if (BotonRecoger.b == true && BotonRecoger2.b == true && BotonRecoger3.b == true)
        {
            panel.SetActive(true);
            MenuPrincipal.finComercial = true;
            if(playAudio == false)
            {
                audiosrc.PlayOneShot(clipCorrecto);
                playAudio = true;
            }
            
        }

        Debug.Log("casilla 1: " + DropSlotComercial1.encasilla + " casilla 2: " + DropSlotComercial2.encasilla + " casilla 3: " + DropSlotComercial3.encasilla);


        if (MenuPrincipal.finComercial == true)
        {
            dos.interactable = false;
            tres.interactable = false;
            validar.interactable = false;
            validar2.interactable = false;
            validar3.interactable = false;
        }
    }
}
