using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnabledParque : MonoBehaviour
{
    public Button validar;
    public Button validar2;
    public GameObject texto;

    // Start is called before the first frame update
    void Start()
    {

        validar.interactable = false;
        validar2.interactable = false;
        texto.SetActive(false);
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
        }
    }

    IEnumerator sisas()
    {
        while (true)
        {
            texto.SetActive(true);
            yield return new WaitForSeconds(3f);
        }
        
    }
}
