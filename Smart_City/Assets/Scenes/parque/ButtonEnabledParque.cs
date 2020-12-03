using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnabledParque : MonoBehaviour
{
    public Button validar;

    // Start is called before the first frame update
    void Start()
    {

        validar.interactable = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (DropSlotParque.encasilla == true)
        {

            validar.interactable = true;
        }
        else
        {

            validar.interactable = false;
        }
    }
}
