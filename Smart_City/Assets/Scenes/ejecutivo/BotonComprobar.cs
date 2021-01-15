using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonComprobar : MonoBehaviour
{
    public Button comprobar;
    public GameObject panel;
    public GameObject panel2;
    public GameObject textoAviso;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        panel2.SetActive(false);
        textoAviso.SetActive(false);
        Button btn = comprobar.GetComponent<Button>();
        btn.onClick.AddListener(comprobarCasos);
    }

    // Update is called once per frame
    void Update()
    {
        if(DropSlotEjecutivo1.encasilla==true && DropSlotEjecutivo2.encasilla == true && DropSlotEjecutivo3.encasilla == true &&
            DropSlotEjecutivo4.encasilla == true && DropSlotEjecutivo5.encasilla == true)
        {
            textoAviso.SetActive(true);
        }
    }

    public void comprobarCasos()
    {
        if (CasosParqueadero.caso5 == true && BotonEspacio1.disponible == false && BotonEspacio2.disponible == false 
            && BotonEspacio3.disponible == true && BotonEspacio4.disponible == false && BotonEspacio5.disponible == true)
        {
            panel.SetActive(true);
            panel2.SetActive(false);
        }
        else
        {
            panel.SetActive(false);
            panel2.SetActive(true);
        }
        if (CasosParqueadero.caso4 == true && BotonEspacio1.disponible == false && BotonEspacio2.disponible == true
            && BotonEspacio3.disponible == false && BotonEspacio4.disponible == true && BotonEspacio5.disponible == false)
        {
            panel.SetActive(true);
            panel2.SetActive(false);
        }
        if (CasosParqueadero.caso3 == true && BotonEspacio1.disponible == true && BotonEspacio2.disponible == true
            && BotonEspacio3.disponible == false && BotonEspacio4.disponible == false && BotonEspacio5.disponible == false)
        {
            panel.SetActive(true);
            panel2.SetActive(false);
        }
        if (CasosParqueadero.caso2 == true && BotonEspacio1.disponible == false && BotonEspacio2.disponible == true
            && BotonEspacio3.disponible == true && BotonEspacio4.disponible == true && BotonEspacio5.disponible == false)
        {
            panel.SetActive(true);
            panel2.SetActive(false);
        }
        if (CasosParqueadero.caso1 == true && BotonEspacio1.disponible == true && BotonEspacio2.disponible == false
            && BotonEspacio3.disponible == false && BotonEspacio4.disponible == false && BotonEspacio5.disponible == true)
        {
            panel.SetActive(true);
            panel2.SetActive(false);
        }
    }
}
