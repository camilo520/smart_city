using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumedadCasas : MonoBehaviour
{

    private int caso;
    public Button humedadB;
    private bool c1, c2, c3;
    public GameObject panelCorrecto;
    public Text tipoCaso;
    public Text correcto;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = humedadB.GetComponent<Button>();
        btn.onClick.AddListener(casos);

        caso = 3;
        c1 = false;
        c2 = false;
        c3 = false;
        panelCorrecto.SetActive(false);
        //StartCoroutine(correctos());
    }

    // Update is called once per frame
    void Update()
    {
        if(c1==true && c2 == true && c3 == true)
        {
            panelCorrecto.SetActive(true);
        }

        if (caso == 1)
        {
            tipoCaso.text = "Dia caluroso";

        }else if (caso == 2)
        {
            tipoCaso.text = "Clima templado";
        }else if (caso == 3)
        {
            tipoCaso.text = "Dia lluvioso";

        }
    }



    private void casos()
    {
        if (caso == 1 && SliderCasas.porc >= 20 && SliderCasas.porc <= 30)
        {
            Debug.Log("Correcto 1");
            StartCoroutine(correctos());
            c1 = true;
            caso = 3;
        }
        if (caso == 1 && c1 == false && SliderCasas.porc < 20 || SliderCasas.porc > 30)
        {
            StartCoroutine(incorrectos());
            Debug.Log("estoy aqui");
        }
        if (caso == 2 && SliderCasas.porc >= 30 && SliderCasas.porc <= 40)
        {
            Debug.Log("Correcto 2");
            StartCoroutine(correctos());
            c2 = true;
            caso = 1;
        }
        if (caso == 2 && c2 ==false && SliderCasas.porc < 30 || SliderCasas.porc > 40)
        {
            StartCoroutine(incorrectos());
        }
        if (caso == 3 && SliderCasas.porc >= 40 && SliderCasas.porc <= 50)
        {
            Debug.Log("Correcto 3");
            StartCoroutine(correctos());
            c3 = true;
            caso = 2;
        }
        if (caso == 3 && c3 == false && SliderCasas.porc < 40 || SliderCasas.porc > 50)
        {
            StartCoroutine(incorrectos());
        }

    }

  
    IEnumerator correctos()
    {
            correcto.color = new Color(0,255,0);
            correcto.text = "Correcto";
                    
            yield return new WaitForSeconds(2);

            correcto.text = "";

            yield return new WaitForSeconds(2);  

    }

    IEnumerator incorrectos()
    {
        correcto.color = new Color(255, 0, 0);
        correcto.text = "Incorrecto";

        yield return new WaitForSeconds(2);

        correcto.text = "";

        yield return new WaitForSeconds(2);

    }

}
