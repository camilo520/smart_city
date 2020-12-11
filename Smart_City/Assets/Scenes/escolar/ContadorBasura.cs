using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorBasura : MonoBehaviour
{

    public Text contador;
    public Text contador2;
    public Text contador3;
    public Text estado;
    public Text estado2;
    public Text estado3;
    public static float tiempo = 0f;
    public static float tiempo2 = 0f;
    public static float tiempo3 = 0f;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        contador.text = " " + tiempo + " Kg";
        contador2.text = " " + tiempo2 + " Kg";
        contador3.text = " " + tiempo3 + " Kg";
        estado.text = "";
        estado2.text = "";
        estado3.text = "";
        StartCoroutine(contaminacion());
    }

    // Update is called once per frame
    void Update()
    {
        //---------------------tiempo1-------------

        if (tiempo>=5 && tiempo <= 14 )
        {
            Debug.Log("Bien");
            estado.text = "Poca basura";
        }
        else if (tiempo >= 15 && tiempo <= 25)
        {
            Debug.Log("Mal");
            estado.text = "Media basura";
        }
        else if(tiempo >=26)
        {
            Debug.Log("En la inmunda");
            estado.text = "Mucha basura";
        }
        else
        {
            estado.text = "";
        }


        //---------------------tiempo2-------------

        if (tiempo2 >= 5 && tiempo2 <= 14)
        {
            Debug.Log("Bien");
            estado2.text = "Poca basura";
        }
        else if (tiempo2 >= 15 && tiempo2 <= 25)
        {
            Debug.Log("Mal");
            estado2.text = "Media basura";
        }
        else if (tiempo2 >= 26)
        {
            Debug.Log("En la inmunda");
            estado2.text = "Mucha basura";
        }
        else
        {
            estado2.text = "";
        }

        //---------------------tiempo3-------------

        if (tiempo3 >= 5 && tiempo3 <= 14)
        {
            Debug.Log("Bien");
            estado3.text = "Poca basura";
        }
        else if (tiempo3 >= 15 && tiempo3 <= 25)
        {
            Debug.Log("Mal");
            estado3.text = "Media basura";
        }
        else if (tiempo3 >= 26)
        {
            Debug.Log("En la inmunda");
            estado3.text = "Mucha basura";
        }
        else
        {
            estado3.text = "";
        }

    }

    IEnumerator contaminacion()
    {
        while (BotonRecoger.b==false)
        {
            
            if (DropSlotComercial1.encasilla == true && DropSlotComercial2.encasilla == true && DropSlotComercial3.encasilla == true)
            {
                
                tiempo += Random.Range(2, 4);
                tiempo2 += Random.Range(2, 4);
                tiempo3 += Random.Range(2, 4);
                contador.text = " " + tiempo.ToString("f0") + " Kg";
                contador2.text = " " + tiempo2.ToString("f0") + " Kg";
                contador3.text = " " + tiempo3.ToString("f0") + " Kg";
                Debug.Log(tiempo);

            }
            else
            {

            }
            yield return new WaitForSeconds(2);
        }
        
    }


}
