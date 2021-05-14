using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnabledParque : MonoBehaviour
{
    public Button validar;
    public Button validar2;
    public Button dos;
    public Button tres;
    public GameObject texto;
    public GameObject texto2;
    public GameObject aspersor1;
    public GameObject aspersor2;
    public GameObject gotas1;
    public GameObject gotas2;
    public GameObject textIN;

    // Start is called before the first frame update
    void Start()
    {

        validar.interactable = false;
        validar2.interactable = false;
        dos.interactable = true;
        tres.interactable = true;
        texto.SetActive(false);
        texto2.SetActive(false);
        aspersor1.SetActive(false);
        aspersor2.SetActive(false);
        gotas1.SetActive(false);
        gotas2.SetActive(false);
        textIN.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (ContadorHumedad.gotas1 == true)
        {
            gotas1.SetActive(true);
        }
        if (ContadorHumedad.gotas2 == true)
        {
            gotas2.SetActive(true);
        }

        if (DropSlotParque.encasilla == true && DropSlotParque2.encasilla == true)
        {

            validar.interactable = true;
            validar2.interactable = true;
            textIN.SetActive(true);
            StartCoroutine(sisas());
            tres.interactable = false;
            
        }
        else
        {

            validar.interactable = false;
            validar2.interactable = false;
            texto.SetActive(false);
            texto2.SetActive(false);
            aspersor1.SetActive(false);
            aspersor2.SetActive(false);
            gotas1.SetActive(false);
            gotas2.SetActive(false);
            textIN.SetActive(false);
            tres.interactable = true;
        }

        if (MenuPrincipal.finParque == true)
        {
            validar.interactable = false;
            validar2.interactable = false;
            dos.interactable = false;
            tres.interactable = false;
        }

    }

    IEnumerator sisas()
    {
        while (true)
        {
            texto.SetActive(true);
            texto2.SetActive(true);
            aspersor1.SetActive(true);
            aspersor2.SetActive(true);
            yield return new WaitForSeconds(1f);
        }
        
    }

   

}
