using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnablesIndustrial : MonoBehaviour
{
    public Button validar;
    public Button dos;
    public Button tres;
    public Button cuatro;
    public GameObject textoAviso;

    // Start is called before the first frame update
    void Start()
    {

        validar.interactable = false;
        dos.interactable = true;
        tres.interactable = true;
        cuatro.interactable = true;
        textoAviso.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (DropSlotIndustrial.encasilla == true)
        {

            validar.interactable = true;
            textoAviso.SetActive(true);
            tres.interactable = false;
        }
        else
        {

            validar.interactable = false;
            textoAviso.SetActive(false);
            tres.interactable = true;
        }

        if (MenuPrincipal.finIndustrial == true)
        {
            validar.interactable = false;
            dos.interactable = false;
            tres.interactable = false;
            cuatro.interactable = false;
        }
    }
}
