using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnableApartamentos : MonoBehaviour
{
    public GameObject slider;
    public GameObject texto1;
    public GameObject texto2;
    public Button validar;

    // Start is called before the first frame update
    void Start()
    {
        slider.SetActive(false);
        texto1.SetActive(false);
        texto2.SetActive(false);
        validar.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (DropSlotApartamentos1.encasilla == true)
        {
            slider.SetActive(true);
            texto1.SetActive(true);
            texto2.SetActive(true);
            validar.interactable = true;
        }
        else
        {
            slider.SetActive(false);
            texto1.SetActive(false);
            texto2.SetActive(false);
            validar.interactable = false;
        }
    }
}
