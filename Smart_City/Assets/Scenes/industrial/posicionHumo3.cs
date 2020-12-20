﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class posicionHumo3 : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public static GameObject humo;
    public static bool desaparece;
    Vector3 posicioninicial;
    Transform startParent;
    Transform dragParent;
    public static bool humo3;
    private int posy;
    // Start is called before the first frame update
    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
        humo3 = false;
        desaparece = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(humo.transform.position.y);
        Debug.Log("humo3 : " + desaparece);
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
        desaparece = false;
        humo3 = false;
        if (posy >= 290)
        {
            desaparece = true;
            humo3 = true;
        }

    }
}