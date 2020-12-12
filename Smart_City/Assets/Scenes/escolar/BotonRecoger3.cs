using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonRecoger3 : MonoBehaviour
{
    public Button recogio;
    private int contador;
    public static bool b;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = recogio.GetComponent<Button>();
        btn.onClick.AddListener(recoger);
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("bote 3: " + b);
    }

    public void recoger()
    {
        while (ContadorBasura.tiempo3 >= 26)
        {
            ContadorBasura.tiempo3 = 0f;
            contador += 1;
        }

        //Debug.Log("contador3 " + contador);
        if (contador == 3)
        {
            b = true;
            ContadorBasura.tiempo3 = 0f;
        }
        else
        {
            b = false;
        }
    }
}
