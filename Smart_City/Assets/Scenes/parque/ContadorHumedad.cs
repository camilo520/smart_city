﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorHumedad : MonoBehaviour
{

    public Text humedad1;
    public Text humedad2;
    public Text avisoHumedad;
    public Text avisoHumedad2;
    public GameObject panelIncorrecto;
    public GameObject panelCorrecto;
    public static float tiempo;
    public static float tiempo2;
    public static bool verdadero1;
    public static bool verdadero2;
    private bool sepaso;
    [SerializeField] private Animator animacion1;
    [SerializeField] private Animator animacion2;
    // Start is called before the first frame update
    void Start()
    {
        tiempo = 500f;
        tiempo2 = 500f;
        StartCoroutine(sumarHume1());
        StartCoroutine(restarHume1());
        StartCoroutine(sumarHume2());
        StartCoroutine(restarHume2());
        humedad1.text = "";
        humedad2.text = "";
        avisoHumedad.text = "";
        avisoHumedad2.text = "";
        verdadero1 = true;
        verdadero2 = true;
        sepaso = false;
        panelCorrecto.SetActive(false);
        panelIncorrecto.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("es asi: " + sepaso);
        if(tiempo <=499f && tiempo2 <= 499f)
        {
            sepaso = true;
            animacion1.SetBool("riegoVerdadero", false);
            animacion2.SetBool("riegoVerdadero", false);
            panelCorrecto.SetActive(true);
        }
        else if (tiempo > 1023 || tiempo2 > 1023)
        {
            sepaso = true;
            animacion1.SetBool("riegoVerdadero", false);
            animacion2.SetBool("riegoVerdadero", false);
            panelIncorrecto.SetActive(true);
        }
        

        if(tiempo>501f && tiempo < 700 && verdadero1 == true)
        {
            avisoHumedad.text = "Suelo Humedo \n" + "No es necesario regarlo";

        }else if (tiempo>=700f && tiempo<1023 && verdadero1 == true)
        {
            avisoHumedad.text = "Suelo Seco \n" + "Riega el parque";
        }
        if (tiempo2 > 501f && tiempo2 < 700 && verdadero2 == true)
        {
            avisoHumedad2.text = "Suelo Humedo \n" + "No es necesario regarlo";

        }
        else if (tiempo2 >= 700f && tiempo2 < 1023 && verdadero2 == true)
        {
            avisoHumedad2.text = "Suelo Seco \n" + "Riega el parque";
        }

    }

    IEnumerator sumarHume1()
    {
        while (sepaso==false)
        {
            if (DropSlotParque.encasilla == true && DropSlotParque2.encasilla == true && verdadero1 == true)
            {
                tiempo += Random.Range(15, 20);
                humedad1.text = " " + tiempo.ToString("f0");
                animacion1.SetBool("riegoFalso", false);
            }
            else
            {
            }
            yield return new WaitForSeconds(2);
        }

    }

    IEnumerator restarHume1()
    {
        while (sepaso==false)
        {
            if (DropSlotParque.encasilla == true && DropSlotParque2.encasilla == true && verdadero1 == false)
            {
                tiempo -= Random.Range(20, 25);
                humedad1.text = " " + tiempo.ToString("f0");
                avisoHumedad.text = "El aspersor 1 esta \n" + "regando el parque";
                animacion1.SetBool("riegoVerdadero", true);
            }
            else
            {

            }
            yield return new WaitForSeconds(2);
        }

    }

    IEnumerator sumarHume2()
    {
        while (sepaso==false)
        {
            if (DropSlotParque.encasilla == true && DropSlotParque2.encasilla == true && verdadero2 == true)
            {
                tiempo2 += Random.Range(15, 20);
                humedad2.text = " " + tiempo2.ToString("f0");
                animacion2.SetBool("riegoFalso", false);
            }
            else
            {
            }
            yield return new WaitForSeconds(2);
        }

    }

    IEnumerator restarHume2()
    {
        while (sepaso==false)
        {
            if (DropSlotParque.encasilla == true && DropSlotParque2.encasilla == true && verdadero2 == false)
            {
                tiempo2 -= Random.Range(20, 25);
                humedad2.text = " " + tiempo2.ToString("f0");
                avisoHumedad2.text = "El aspersor 2 esta \n" + "regando el parque";
                animacion2.SetBool("riegoVerdadero", true);
            }
            else
            {

            }
            yield return new WaitForSeconds(2);
        }

    }

}
