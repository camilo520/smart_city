using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ContadorContaminacion : MonoBehaviour
{

    public Text numeroContaminacion;
    public Text avisoContaminacion1;
    public GameObject nube1;
    public GameObject nube2;
    public GameObject nube3;
    public static float contaminacion;
    public static bool verdadero1;
    public static bool verdadero2;
    public static bool sepaso;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(sumarContaminacion());
        StartCoroutine(restarContaminacion());
        numeroContaminacion.text = "";
        avisoContaminacion1.text = "";
        verdadero1 = true;
        verdadero2 = true;
        contaminacion = 0f;
        sepaso = false;
        nube1.SetActive(false);
        nube2.SetActive(false);
        nube3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("¿se paso?: " + sepaso);
        if (contaminacion >= 800f)
        {

        }
        if (sepaso == true)
        {
            nube1.SetActive(true);
            nube2.SetActive(true);
            nube3.SetActive(true);
        }
        if (sepaso == true && posicionHumo.desaparece == true)
        {
            nube1.SetActive(false);
        }
        if (sepaso == true && posicionHumo2.desaparece == true)
        {
            nube2.SetActive(false);
        }
        if (sepaso == true && posicionHumo3.desaparece == true)
        {

            nube3.SetActive(false);
        }


    }

    IEnumerator sumarContaminacion()
    {
        while (sepaso == false)
        {
            if (DropSlotIndustrial.encasilla == true )
            {
                contaminacion += Random.Range(50, 50);
                numeroContaminacion.text = " " + contaminacion.ToString("f0");
            }
            else
            {
            }
            yield return new WaitForSeconds(1);
        }

    }

    IEnumerator restarContaminacion()
    {
        while (true)
        {
            if (DropSlotIndustrial.encasilla == true && posicionHumo.humo1 == true && posicionHumo2.humo2 == true && posicionHumo3.humo3 == true)
            {
                contaminacion -= Random.Range(50, 50);
                numeroContaminacion.text = " " + contaminacion.ToString("f0");
            }
            else
            {
            }
            yield return new WaitForSeconds(1);
        }

    }
}
