using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class PosicionBotones : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject apartamentos;
    public GameObject casas;
    public GameObject ejecutivo;
    public GameObject comercial;
    public GameObject industrial;
    public GameObject educativo;
    public GameObject parque;

    private void Start()
    {
        apartamentos.SetActive(false);
        casas.SetActive(false);
        ejecutivo.SetActive(false);
        comercial.SetActive(false);
        industrial.SetActive(false);
        educativo.SetActive(false);
        parque.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
        if (name.Equals("apartamentos1"))
        {
            apartamentos.SetActive(true);
        }

        if (name.Equals("ejecutivo1"))
        {
            ejecutivo.SetActive(true);
        }

        if (name.Equals("escolar1"))
        {
            comercial.SetActive(true);
        }

        if (name.Equals("casas1"))
        {
            casas.SetActive(true);
        }

        if (name.Equals("industrial1"))
        {
            industrial.SetActive(true);
        }

        if (name.Equals("mixta1"))
        {
            educativo.SetActive(true);
        }

        if (name.Equals("parque1"))
        {
            parque.SetActive(true);
        }
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        if (!name.Equals(""))
        {
            apartamentos.SetActive(false);
            casas.SetActive(false);
            ejecutivo.SetActive(false);
            comercial.SetActive(false);
            industrial.SetActive(false);
            educativo.SetActive(false);
            parque.SetActive(false);
        }
    }
}
