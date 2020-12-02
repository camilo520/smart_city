using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnabledComercial : MonoBehaviour
{
    public GameObject contador;
    public Button validar;

    // Start is called before the first frame update
    void Start()
    {
        contador.SetActive(false);
        validar.interactable = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (DropSlotComercial1.encasilla == true)
        {
            contador.SetActive(true);
            validar.interactable = true;
        }
        else
        {
            contador.SetActive(false);
            validar.interactable = false;
        }
    }
}
