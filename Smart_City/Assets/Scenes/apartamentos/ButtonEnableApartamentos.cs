using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnableApartamentos : MonoBehaviour
{
    public GameObject slider;
    public GameObject texto1;
    public GameObject texto2;
    public GameObject textoIN;
    public Button validar;
    public Button dos;
    public Button tres;
    public Button cuatro;

    // Start is called before the first frame update
    void Start()
    {
        slider.SetActive(false);
        texto1.SetActive(false);
        texto2.SetActive(false);
        textoIN.SetActive(false);
        validar.interactable = false;
        dos.interactable = true;
        tres.interactable = true;
        cuatro.interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (DropSlotApartamentos1.encasilla == true)
        {
            slider.SetActive(true);
            texto1.SetActive(true);
            texto2.SetActive(true);
            textoIN.SetActive(true);
            tres.interactable = false;
            validar.interactable = true;
        }
        else
        {
            slider.SetActive(false);
            texto1.SetActive(false);
            texto2.SetActive(false);
            textoIN.SetActive(false);
            tres.interactable = true;
            validar.interactable = false;
        }

        if (MenuPrincipal.finApartamento == true)
        {
            validar.interactable = false;
            dos.interactable = false;
            tres.interactable = false;
            cuatro.interactable = false;
        }
    }
}
