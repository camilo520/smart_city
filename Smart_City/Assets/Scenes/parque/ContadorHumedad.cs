using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorHumedad : MonoBehaviour
{

    public Text humedad1;
    public static float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(contadorHume1());
        humedad1.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator contadorHume1()
    {
        tiempo = 600f;
        while (tiempo<1000f)
        {
            if (DropSlotParque.encasilla == true && DropSlotParque2.encasilla == true )
            {
                tiempo += Random.Range(15, 20);
                humedad1.text = " " + tiempo.ToString("f0");

            }
            else
            {

            }
            yield return new WaitForSeconds(2);


        }

    }
}
