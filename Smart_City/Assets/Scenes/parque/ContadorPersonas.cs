using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorPersonas : MonoBehaviour
{
    public Text contador;
    //public bool condition = false;
    private float personas = 0f;
    public Button sumar, restar;
    // Start is called before the first frame update
    void Start()
    {
        contador.text = " " + personas + " Persona(s)";

        Button btn = sumar.GetComponent<Button>();
        btn.onClick.AddListener(sumarPersonas);

        Button btn2 = restar.GetComponent<Button>();
        btn2.onClick.AddListener(restarPersonas);

            //StartCoroutine(contaminacion());
    }

    // Update is called once per frame
    void Update()
    {

        contador.text = " " + personas.ToString("f0") + " Persona(s)";
        Debug.Log(personas);

        if (personas >= 5 && personas <= 7)
        {
            Debug.Log("Pocas personas");
        }
        else if (personas >= 8 && personas <= 14)
        {
            Debug.Log("Muchas personas");
        }
        else if (personas >= 15)
        {
            Debug.Log("Aglomeracion");

        }
    }

    private void sumarPersonas()
    {
        personas += 1;  
    }

    private void restarPersonas()
    {
        if (personas == 0)
        {
            personas = 0;
        }
        else
        {
            personas -= 1;
        }
        
    }
}
