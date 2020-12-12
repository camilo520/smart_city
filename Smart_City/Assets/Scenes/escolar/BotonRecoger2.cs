using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonRecoger2 : MonoBehaviour
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
        Debug.Log("bote 2: " + b);
    }

    public void recoger()
    {
        while (ContadorBasura.tiempo2 >= 26)
        {
            ContadorBasura.tiempo2 = 0f;
            contador += 1;
        }

        //Debug.Log("contador2 " + contador);
        if (contador == 3)
        {
            b = true;
            
            ContadorBasura.tiempo2 = 0f;
        }
        else
        {
            b = false;
            
        }
    }
}
