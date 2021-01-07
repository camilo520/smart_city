using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlotCasas3 : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public static bool encasilla;

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragHandlerCasas.itemDragginng;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            Debug.Log("Soy el tercero");
            encasilla = true;
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
            encasilla = false;
            item = null;
            Debug.Log("No la pusiste");
        }
    }
}
