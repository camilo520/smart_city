using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelCompletado : MonoBehaviour
{
    public GameObject panelC;

    // Start is called before the first frame update
    void Start()
    {
        panelC.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (MenuPrincipal.finApartamento == true && MenuPrincipal.finCasa == true && MenuPrincipal.finComercial == true
            && MenuPrincipal.finEjecutivo == true && MenuPrincipal.finIndustrial == true && MenuPrincipal.finParque == true)
        {
            panelC.SetActive(true);
        }
        else
        {
            panelC.SetActive(false);
        }
    }
}
