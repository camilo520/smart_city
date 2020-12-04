using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class posicionHumo : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{

    public static GameObject humo;
    public Text texto;
    Vector3 posicioninicial;
    Transform startParent;
    Transform dragParent;
    private int posy;
    // Start is called before the first frame update
    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
        texto.text = "";
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
        if (posy >= 200)
        {
            Debug.Log("Esta en el cielo");
            texto.text = "Contaminacion en la atmosfera";
        }
        else if (posy<=199 && posy>=0)
        {
            Debug.Log("En la calle");
            texto.text = "Contaminacion muy cerca de la ciudad";
        }
        else
        {
            Debug.Log("En el infierno");
        }
    }
}
