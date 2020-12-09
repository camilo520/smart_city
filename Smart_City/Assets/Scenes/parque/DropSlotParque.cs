using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlotParque : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public GameObject texto1;
    public GameObject texto2;
    public GameObject slider1;
    public GameObject slider2;
    public GameObject porcentaje1;
    public GameObject porcentaje2;

    public static bool encasilla;

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragHandlerParqueCorrecto.itemDragginng;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            Debug.Log("Soy el primero");
            encasilla = true;
            texto1.SetActive(true);
            texto2.SetActive(true);
            slider1.SetActive(true);
            slider2.SetActive(true);
            porcentaje1.SetActive(true);
            porcentaje2.SetActive(true);
        }
        else
        {
            encasilla = false;
            texto1.SetActive(false);
            texto2.SetActive(false);
            slider1.SetActive(false);
            slider2.SetActive(false);
            porcentaje1.SetActive(false);
            porcentaje2.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        encasilla = false;
        texto1.SetActive(false);
        texto2.SetActive(false);
        slider1.SetActive(false);
        slider2.SetActive(false);
        porcentaje1.SetActive(false);
        porcentaje2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
            encasilla = false;
            texto1.SetActive(false);
            texto2.SetActive(false);
            slider1.SetActive(false);
            slider2.SetActive(false);
            porcentaje1.SetActive(false);
            porcentaje2.SetActive(false);
            Debug.Log("No la pusiste");
        }
    }
}
