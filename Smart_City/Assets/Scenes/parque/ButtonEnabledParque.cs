using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnabledParque : MonoBehaviour
{
    public Button validar;
    public Button validar2;
    public GameObject texto;
    public GameObject texto2;
    public GameObject aspersor1;
    public GameObject aspersor2;

    // Start is called before the first frame update
    void Start()
    {

        validar.interactable = false;
        validar2.interactable = false;
        texto.SetActive(false);
        texto2.SetActive(false);
        aspersor1.SetActive(false);
        aspersor2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (DropSlotParque.encasilla == true && DropSlotParque2.encasilla == true)
        {

            validar.interactable = true;
            validar2.interactable = true;
            StartCoroutine(sisas());
        }
        else
        {

            validar.interactable = false;
            validar2.interactable = false;
            texto.SetActive(false);
            texto2.SetActive(false);
            aspersor1.SetActive(false);
            aspersor2.SetActive(false);
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
            yield return new WaitForSeconds(3f);
        }
        
    }
}
