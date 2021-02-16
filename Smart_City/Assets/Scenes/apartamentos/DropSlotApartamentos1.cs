using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlotApartamentos1 : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public GameObject slot;
    public GameObject slot2;
    public static bool encasilla;

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragHandlerAparatamentosCorrecto.itemDragginng;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            Debug.Log("Soy el primero");
            encasilla = true; 
            slot.SetActive(true);
            slot2.SetActive(false);
        }
        else
        {
            encasilla = false;
            slot.SetActive(false);
            slot2.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        encasilla = false;
        slot.SetActive(false);
        slot2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
            encasilla = false;
            slot.SetActive(false);
            slot2.SetActive(true);
            Debug.Log("No la pusiste");
        }
    }
}
