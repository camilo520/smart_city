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
        contador.text = " " + tiempo;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        contador.text = " " + tiempo.ToString("f0");
        /*if(tiempo>=5 && tiempo <= 10)
        {
            Debug.Log("Bien");
        }
        else if (tiempo >= 11 && tiempo <= 20)
        {
            Debug.Log("Mal");
        }
        else if(tiempo >=21)
        {
            Debug.Log("En la inmunda");

        }*/
    }

}
