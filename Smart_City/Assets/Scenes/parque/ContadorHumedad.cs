using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorHumedad : MonoBehaviour
{

    public Text humedad1;
    public static float tiempo;
    public static bool verdadero;
    private bool sepaso;
    // Start is called before the first frame update
    void Start()
    {
        tiempo = 600f;
        StartCoroutine(sumarHume());
        StartCoroutine(restarHume());
        humedad1.text = "";
        verdadero = true;
        sepaso = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("es asi: " + sepaso);
        if(tiempo>=550f && tiempo <=600f)
        {
            sepaso = false;
            verdadero = true;
        }
        else if(tiempo>750f && tiempo <= 1000f)
        {
            sepaso = true;
        }
        Debug.Log("sepaso: " + sepaso);
    }

    IEnumerator sumarHume()
    {
        while (true)
        {
            if (DropSlotParque.encasilla == true && DropSlotParque2.encasilla == true && verdadero == true)
            {
                tiempo += Random.Range(25, 30);
                humedad1.text = " " + tiempo.ToString("f0");
            }
            else
            {
            }
            yield return new WaitForSeconds(2);
        }

    }

    IEnumerator restarHume()
    {
        while (true)
        {
            if (DropSlotParque.encasilla == true && DropSlotParque2.encasilla == true && verdadero == false && sepaso==true)
            {
                tiempo -= Random.Range(25, 30);
                humedad1.text = " " + tiempo.ToString("f0");
            }
            else
            {
                
            }
            yield return new WaitForSeconds(2);
        }

    }



}
