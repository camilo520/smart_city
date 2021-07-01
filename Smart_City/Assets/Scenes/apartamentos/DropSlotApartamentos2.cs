using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlotApartamentos2 : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public static bool encasilla;

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragHandlerApartamentos.itemDragginng;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            encasilla = true;
        }
        else
        {
            encasilla = false;
        }
    }


    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
        }
    }
}
