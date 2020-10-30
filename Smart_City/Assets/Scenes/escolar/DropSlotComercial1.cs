using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlotComercial1 : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public static bool encasilla;

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragHandlerComercial.itemDragginng;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            Debug.Log("Soy el primero");
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

    }

    // Update is called once per frame
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
            Debug.Log("No la pusiste");
        }
    }

}
