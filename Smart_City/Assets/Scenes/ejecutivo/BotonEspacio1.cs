using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BotonEspacio1 : MonoBehaviour
{
    public Button botonOcupar;
    public Button botonVaciar;
    public static bool disponible = true;
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
        texto.text = "Ocupado";
        disponible = false;
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void ocuparEspacio()
    {
        Button btn = botonOcupar.GetComponent<Button>();
        Button btn2 = botonVaciar.GetComponent<Button>();
        btn.gameObject.SetActive(false);
        btn2.gameObject.SetActive(true);
        disponible = false;
        texto.text = "Ocupado";
    }
    public void vaciarEspacio()
    {
        Button btn = botonOcupar.GetComponent<Button>();
        Button btn2 = botonVaciar.GetComponent<Button>();
        btn.gameObject.SetActive(true);
        btn2.gameObject.SetActive(false);
        disponible = true;
        texto.text = "Vacio";
    }


}
