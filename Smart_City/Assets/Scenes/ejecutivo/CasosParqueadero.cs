﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CasosParqueadero : MonoBehaviour
{
    private int intelligence;
    public static bool caso5;
    public static bool caso4;
    public static bool caso3;
    public static bool caso2;
    public static bool caso1;
    public static int tipoCaso;
    public Text avisoCaso;
    // Start is called before the first frame update
    void Start()
    {
        tipoCaso = 0;
        caso5 = false;
        caso4 = false;
        caso3 = false;
        caso2 = false;
        caso1 = false;
        avisoCaso.text = "";
        intelligence = Random.Range(1,6);
        Greet();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("tipo caso: " + tipoCaso.ToString());
    }

    void Greet()
    {
        switch (intelligence)
        {
            case 5:
                Debug.Log("caso 5");
                caso5 = true;
                tipoCaso = 5;
                avisoCaso.text= "Espacios ocupados: 1, 2 y 4 \n" + "Espacios disponibles: 3 y 5";
                break;
            case 4:
                tipoCaso = 4;
                Debug.Log("caso 4");
                caso4=true;
                avisoCaso.text = "Espacios ocupados: 1, 3 y 5 \n" + "Espacios disponibles: 2 y 4";
                break;
            case 3:
                tipoCaso = 3;
                Debug.Log("caso 3");
                caso3 = true;
                avisoCaso.text = "Espacios ocupados: 3, 4 y 5 \n" + "Espacios disponibles: 1 y 2";
                break;
            case 2:
                tipoCaso = 2;
                Debug.Log("caso 2");
                caso2 = true;
                avisoCaso.text = "Espacios ocupados: 1, y 5 \n" + "Espacios disponibles: 2, 3 y 4";
                break;
            case 1:
                tipoCaso = 1;
                Debug.Log("caso 1");
                caso1 = true;
                avisoCaso.text = "Espacios ocupados: 2, 3 y 4 \n" + "Espacios disponibles: 1 y 5";
                break;
            default:
                tipoCaso = 0;
                avisoCaso.text = ("Incorrect intelligence level.");
                break;
        }
    }
}
