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
    public GameObject panelCorrecto;
    public GameObject panelIncorrecto;
    public static float contaminacion;
    public static bool sepaso;
    private bool correcto;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(sumarContaminacion());
        StartCoroutine(restarContaminacion());
        numeroContaminacion.text = "";
        avisoContaminacion1.text = "";
        contaminacion = 100f;
        sepaso = false;
        nube1.SetActive(false);
        nube2.SetActive(false);
        nube3.SetActive(false);
        panelCorrecto.SetActive(false);
        panelIncorrecto.SetActive(false);
        correcto = false;
        posicionHumo.humo1 = false;
        posicionHumo2.humo2 = false;
        posicionHumo3.humo3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("¿se paso?: " + sepaso);
        if (sepaso == true && correcto==false)
        {
            nube1.SetActive(true);
            nube2.SetActive(true);
            nube3.SetActive(true);
        }
        if (sepaso == true && posicionHumo.humo1 == true)
        {
            nube1.SetActive(false);
        }
        if (sepaso == true && posicionHumo2.humo2 == true)
        {
            nube2.SetActive(false);
        }
        if (sepaso == true && posicionHumo3.humo3 == true)
        {
            nube3.SetActive(false);
        }

        
        if (contaminacion >= 950f)
        {
            panelIncorrecto.SetActive(true);
            correcto = true;
        }
        if (contaminacion < 0f)
        {
            panelCorrecto.SetActive(true);
            correcto = true;
        }
        Debug.Log("¿es correcto?: " + correcto);
        Debug.Log("humo1: " + posicionHumo.humo1);
    }

    IEnumerator sumarContaminacion()
    {
        while (sepaso == false && correcto==false)
        {
            if (DropSlotIndustrial.encasilla == true)
            {
                contaminacion += Random.Range(50, 50);
                numeroContaminacion.text = " " + contaminacion.ToString("f0") + " ppm";
                avisoContaminacion1.text = "La contaminacion esta subiendo";
                if (contaminacion >= 487f && contaminacion <= 797f)
                {
                    avisoContaminacion1.text = "Lanzar alerta de contaminacion";
                }
            }
            else
            {
            }
            yield return new WaitForSeconds(1);
        }

    }

    IEnumerator restarContaminacion()
    {
        while (correcto==false)
        {
            if (DropSlotIndustrial.encasilla == true && sepaso== true && posicionHumo.humo1 == true && posicionHumo2.humo2 == true && posicionHumo3.humo3 == true)
            {
                contaminacion -= Random.Range(50, 50);
                numeroContaminacion.text = " " + contaminacion.ToString("f0") + " ppm";
                avisoContaminacion1.text = "La contaminacion esta bajando";
            }
            else
            {
            }
            yield return new WaitForSeconds(1);
        }

    }
}
