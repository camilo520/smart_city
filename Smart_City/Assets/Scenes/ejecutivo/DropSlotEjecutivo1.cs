using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlotEjecutivo1 : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public GameObject contador;
    public GameObject sumar;
    public GameObject restar;

    public static bool encasilla;

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragHandlerEjecutivoCorrecto.itemDragginng;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            Debug.Log("Soy el primero");
            encasilla = true;
            contador.SetActive(true);
            sumar.SetActive(true);
            restar.SetActive(true);
        }
        else
        {
            encasilla = false;
            contador.SetActive(false);
            sumar.SetActive(false);
            restar.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        encasilla = false;
        contador.SetActive(false);
        sumar.SetActive(false);
        restar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
            encasilla = false;
            contador.SetActive(false);
            sumar.SetActive(false);
            restar.SetActive(false);
            Debug.Log("No la pusiste");
        }
    }
}
