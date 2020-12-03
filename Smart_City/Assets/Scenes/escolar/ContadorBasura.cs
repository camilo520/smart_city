using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorBasura : MonoBehaviour
{

    public Text contador;
    public Text estado;
    public static float tiempo = 0f;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        contador.text = " " + tiempo + " Kg";
        estado.text = "";
        StartCoroutine(contaminacion());
    }

    // Update is called once per frame
    void Update()
    {
        
        if(tiempo>=5 && tiempo <= 14)
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
    }

    IEnumerator contaminacion()
    {
        while (BotonRecoger.b==false)
        {
            
            if (DropSlotComercial1.encasilla == true)
            {
                
                tiempo += Random.Range(2, 4);
                contador.text = " " + tiempo.ToString("f0") + " Kg";
                Debug.Log(tiempo);

            }
            else
            {

            }
            yield return new WaitForSeconds(2);
        }
        
    }


}
