using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnableEjecutivo : MonoBehaviour
{
    public Button continuar;
    public Button dos;
    public Button tres;
    // Start is called before the first frame update
    void Start()
    {
        continuar.interactable = false;
        dos.interactable = true;
        tres.interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (DropSlotEjecutivo1.encasilla == true && DropSlotEjecutivo2.encasilla == true && DropSlotEjecutivo3.encasilla == true &&
            DropSlotEjecutivo4.encasilla == true && DropSlotEjecutivo5.encasilla == true)
        {
            continuar.interactable = true;
        }
        else
        {
            continuar.interactable = false;
        }

        if (MenuPrincipal.finEjecutivo == true)
        {
            continuar.interactable = false;
            dos.interactable = false;
            tres.interactable = false;
        }
    }
}
