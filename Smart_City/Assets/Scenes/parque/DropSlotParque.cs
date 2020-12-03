using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlotParque : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public GameObject mas;
    public GameObject menos;
    public GameObject contador;
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
            mas.SetActive(true);
            menos.SetActive(true);
            contador.SetActive(true);
        }
        else
        {
            encasilla = false;
            mas.SetActive(false);
            menos.SetActive(false);
            contador.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        encasilla = false;
        mas.SetActive(false);
        menos.SetActive(false);
        contador.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
            encasilla = false;
            mas.SetActive(false);
            menos.SetActive(false);
            contador.SetActive(false);
            Debug.Log("No la pusiste");
        }
    }
}
