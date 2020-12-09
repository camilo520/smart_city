﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlotIndustrial : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public GameObject humo;
    public static bool encasilla;

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragHandlerIndustrialCorrecto.itemDragginng;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            Debug.Log("Soy el primero");
            encasilla = true;
            humo.SetActive(true);
        }
        else
        {
            encasilla = false;
            humo.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        encasilla = false;
        humo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
            encasilla = false;
            humo.SetActive(false);
            Debug.Log("No la pusiste");
        }
    }
}