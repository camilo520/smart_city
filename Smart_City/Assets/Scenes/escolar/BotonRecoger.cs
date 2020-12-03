using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonRecoger : MonoBehaviour
{
    public Button recogio;
    public GameObject panel;
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
       
    }

    public void recoger()
    {
        while (ContadorBasura.tiempo >=26)
        {
            ContadorBasura.tiempo = 0f;
            contador += 1;
        }

        Debug.Log("este es el contador de intentos " + contador);
        if (contador == 3)
        {
            b = true;
            panel.SetActive(true);
            ContadorBasura.tiempo = 0f;
        }
        else
        {
            b = false;
            panel.SetActive(false);
        }
    }
}
