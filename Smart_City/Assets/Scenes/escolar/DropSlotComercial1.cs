﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlotComercial1 : MonoBehaviour, IDropHandler
{
    public GameObject item;
    //public GameObject textoContador;
    public static bool encasilla;

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragHandlerComercialCorrecto.itemDragginng;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            Debug.Log("Soy el primero");
            encasilla = true;
            //textoContador.SetActive(true);
        }
        else
        {
            encasilla = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        encasilla = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null; 
            encasilla = false;
            Debug.Log("No la pusiste");
        }
    }

}
