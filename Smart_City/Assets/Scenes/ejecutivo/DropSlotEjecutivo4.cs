using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlotEjecutivo4 : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public GameObject espacio4;

    public static bool encasilla;

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragHandlerEjecutivoCorrecto.itemDragginng;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            Debug.Log("Soy el cuarto");
            encasilla = true;
            espacio4.SetActive(true);
        }
        else
        {
            encasilla = false;
            espacio4.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        encasilla = false;
        espacio4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
            encasilla = false;
            espacio4.SetActive(false);
            Debug.Log("No la pusiste");
        }
    }
}
