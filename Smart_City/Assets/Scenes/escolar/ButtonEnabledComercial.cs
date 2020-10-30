using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnabledComercial : MonoBehaviour
{
    public Button continuar;

    // Start is called before the first frame update
    void Start()
    {
        continuar.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (DropSlotComercial1.encasilla == true && DropSlotComercial2.encasilla == true && DropSlotComercial3.encasilla == true)
        {
            continuar.interactable = true;
        }
        else
        {
            continuar.interactable = false;
        }
    }
}
