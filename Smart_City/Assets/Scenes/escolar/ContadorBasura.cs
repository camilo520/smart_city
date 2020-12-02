using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorBasura : MonoBehaviour
{

    public Text contador;
    private float tiempo = 0f;
    // Start is called before the first frame update
    void Start()
    {
        contador.text = " " + tiempo + " Kg";
        StartCoroutine(contaminacion());
    }

    // Update is called once per frame
    void Update()
    {
        
        if(tiempo>=5 && tiempo <= 14)
        {
            Debug.Log("Bien");
        }
        else if (tiempo >= 15 && tiempo <= 30)
        {
            Debug.Log("Mal");
        }
        else if(tiempo >=31)
        {
            Debug.Log("En la inmunda");

        }
    }

    IEnumerator contaminacion()
    {
        while (true)
        {
            
            if (DropSlotComercial1.encasilla == true)
            {
                
                tiempo += Random.Range(1, 8);
                contador.text = " " + tiempo.ToString("f0") + " Kg";
                Debug.Log(tiempo);

            }
            else
            {

            }
            yield return new WaitForSeconds(3);
        }
        
    }
}
