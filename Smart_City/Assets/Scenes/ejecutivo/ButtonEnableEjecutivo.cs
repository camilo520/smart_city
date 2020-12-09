using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnableEjecutivo : MonoBehaviour
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
        if (DropSlotEjecutivo1.encasilla == true)
        {
            continuar.interactable = true;
        }
        else
        {
            continuar.interactable = false;
        }
    }
}
