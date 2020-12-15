using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonEspacio3 : MonoBehaviour
{
    public Button botonOcupar;
    public Button botonVaciar;
    private bool disponible = true;
    private bool noDisponible;
    public static string espacio1;
    public Text texto;

    // Start is called before the first frame update
    void Start()
    {
        disponible = true;
        Button btn = botonOcupar.GetComponent<Button>();
        btn.onClick.AddListener(ocuparEspacio);
        Button btn2 = botonVaciar.GetComponent<Button>();
        btn2.onClick.AddListener(vaciarEspacio);
        texto.text = "vacio";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("no disponible: " + noDisponible);
    }


    public void ocuparEspacio()
    {
        Button btn = botonOcupar.GetComponent<Button>();
        Button btn2 = botonVaciar.GetComponent<Button>();
        btn.gameObject.SetActive(false);
        btn2.gameObject.SetActive(true);
        texto.text = "ocupado";
    }
    public void vaciarEspacio()
    {
        Button btn = botonOcupar.GetComponent<Button>();
        Button btn2 = botonVaciar.GetComponent<Button>();
        btn.gameObject.SetActive(true);
        btn2.gameObject.SetActive(false);
        texto.text = "vacio";
    }

}
