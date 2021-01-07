using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnableCasas : MonoBehaviour
{
    public Button continuar;
    public GameObject slider;
    public GameObject signo;
    public GameObject porcentaje;
    public GameObject tipoCaso;

    // Start is called before the first frame update
    void Start()
    {
        continuar.interactable = false;
        slider.SetActive(false);
        signo.SetActive(false);
        porcentaje.SetActive(false);
        tipoCaso.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(DropSlotCasas1.encasilla==true && DropSlotCasas2.encasilla == true && DropSlotCasas3.encasilla == true)
        {
            continuar.interactable = true;
            slider.SetActive(true);
            signo.SetActive(true);
            porcentaje.SetActive(true);
            tipoCaso.SetActive(true);
        }
        else
        {
            continuar.interactable = false;
            slider.SetActive(false);
            signo.SetActive(false);
            porcentaje.SetActive(false);
            tipoCaso.SetActive(false);
        }
    }
}
