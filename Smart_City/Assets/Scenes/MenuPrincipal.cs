using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{
    public static bool finApartamento = false;
    public static bool finCasa = false;
    public static bool finComercial = false;
    public static bool finEjecutivo = false;
    public static bool finParque = false;
    public static bool finIndustrial = false;

    public GameObject zonaApartamentos;
    public GameObject zonaCasas;
    public GameObject zonaComercial;
    public GameObject zonaEjecutivo;
    public GameObject zonaParque;
    public GameObject zonaIndustrial;

    public GameObject BApartamentos;
    public GameObject BCasas;
    public GameObject BComercial;
    public GameObject BEjecutivo;
    public GameObject BParque;
    public GameObject BIndustrial;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("MusicAP").GetComponent<MusicaApartamentos>().StopMusic();
    }

    // Update is called once per frame
    void Update()
    {
        if (finApartamento == true)
        {
            zonaApartamentos.SetActive(false);
            BApartamentos.SetActive(true);
        }

        if (finCasa == true)
        {
            zonaCasas.SetActive(false);
            BCasas.SetActive(true);
        }

        if (finComercial == true)
        {
            zonaComercial.SetActive(false);
            BComercial.SetActive(true);
        }

        if (finEjecutivo == true)
        {
            zonaEjecutivo.SetActive(false);
            BEjecutivo.SetActive(true);
        }

        if (finParque == true)
        {
            zonaParque.SetActive(false);
            BParque.SetActive(true);
        }

        if (finIndustrial == true)
        {
            zonaIndustrial.SetActive(false);
            BIndustrial.SetActive(true);
        }

    }
}
