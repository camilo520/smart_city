using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandlerComercialCorrecto : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public static GameObject itemDragginng;

    Vector3 posicioninicial;
    Transform startParent;
    Transform dragParent;


    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        itemDragginng = gameObject;
        posicioninicial = transform.position;
        startParent = transform.parent;
        transform.SetParent(dragParent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        itemDragginng = null;

        if (transform.parent == dragParent)
        {
            transform.position = posicioninicial;
            transform.SetParent(startParent);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent1").transform;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
