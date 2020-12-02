using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class posicionHumo : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{

    public static GameObject humo;
    Vector3 posicioninicial;
    Transform startParent;
    Transform dragParent;
    private int posy;
    // Start is called before the first frame update
    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(humo.transform.position.y);
        
        contaminado();
    }

    


    public void OnBeginDrag(PointerEventData eventData)
    {

        humo = gameObject;
        posicioninicial = transform.position;
        startParent = transform.parent;
        transform.SetParent(dragParent);
    }

    public void OnDrag(PointerEventData eventData)
    {

        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        humo = null;

        /*if (transform.parent == dragParent)
        {
            transform.position = posicioninicial;
            transform.SetParent(startParent);
        }*/

        transform.SetParent(dragParent);
    }

    private void contaminado()
    {
        humo = gameObject;
        Int32.TryParse(humo.transform.position.y.ToString(), out posy);
        if (posy >= 255)
        {
            Debug.Log("Esta en el cielo");
        }
        else if (posy >= 170 && posy<255)
        {
            Debug.Log("Esta en los edificios");
        }
        else if (posy<170 && posy>=0)
        {
            Debug.Log("En la calle");
        }
        else
        {
            Debug.Log("En el infierno");
        }
    }
}
