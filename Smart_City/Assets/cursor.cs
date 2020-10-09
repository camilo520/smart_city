using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class cursor : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{

    public Texture2D hand;
    public Animator anim;

    private void Start()
    {

    }

    private void Update()
    {
    }

    public void OnPointerClick(PointerEventData eventDat)
    {
        if (name.Equals("apartamentos1"))
        {
            anim.SetTrigger("Activate");
        }
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        print("OnMouseEnter");
        Cursor.SetCursor(hand, Vector2.zero, CursorMode.ForceSoftware);

    }


    public void OnPointerExit(PointerEventData eventData)
    {
        print("OnMouseExit");
        Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
    }



}
