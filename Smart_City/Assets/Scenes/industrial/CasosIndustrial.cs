using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CasosIndustrial : MonoBehaviour
{
    private int intelligence;
    public static bool caso3;
    public static bool caso2;
    public static bool caso1;
    public Text avisoCaso;
    // Start is called before the first frame update
    void Start()
    {
        caso3 = false;
        caso2 = false;
        caso1 = false;
        avisoCaso.text = "";
        intelligence = Random.Range(1, 4);
        Greet();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Greet()
    {
        switch (intelligence)
        {
            case 3:
                Debug.Log("caso 3");
                caso3 = true;
                avisoCaso.text = "Contaminacion de O3";
                break;
            case 2:
                Debug.Log("caso 2");
                caso2 = true;
                avisoCaso.text = "Contaminacion de SO2";
                break;
            case 1:
                Debug.Log("caso 1");
                caso1 = true;
                avisoCaso.text = "Contaminacion de NO2";
                break;
            default:
                avisoCaso.text = ("Incorrect intelligence level.");
                break;
        }
    }
}
