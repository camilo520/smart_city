using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnablesIndustrial : MonoBehaviour
{
    public Button validar;
    public GameObject textoAviso;

    // Start is called before the first frame update
    void Start()
    {

        validar.interactable = false;
        textoAviso.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (DropSlotIndustrial.encasilla == true)
        {

            validar.interactable = true;
            textoAviso.SetActive(true);
        }
        else
        {

            validar.interactable = false;
            textoAviso.SetActive(false);
        }
    }
}
