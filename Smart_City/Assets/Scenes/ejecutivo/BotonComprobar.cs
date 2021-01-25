using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonComprobar : MonoBehaviour
{
    public Button comprobar;
    public GameObject panel;
    public GameObject panel2;
    public GameObject textoAviso;
    public static AudioClip clipCorrecto;
    public static AudioClip clipIncorrecto;
    public AudioSource audiosrc;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        panel2.SetActive(false);
        textoAviso.SetActive(false);
        Button btn = comprobar.GetComponent<Button>();
        btn.onClick.AddListener(comprobarCasos);
        clipCorrecto = Resources.Load<AudioClip>("succes_sound2");
        clipIncorrecto = Resources.Load<AudioClip>("sound_failder");
        audiosrc.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(DropSlotEjecutivo1.encasilla==true && DropSlotEjecutivo2.encasilla == true && DropSlotEjecutivo3.encasilla == true &&
            DropSlotEjecutivo4.encasilla == true && DropSlotEjecutivo5.encasilla == true)
        {
            textoAviso.SetActive(true);

        }
    }

    public void comprobarCasos()
    {
        if (CasosParqueadero.caso5 == true && BotonEspacio1.disponible == false && BotonEspacio2.disponible == false 
            && BotonEspacio3.disponible == true && BotonEspacio4.disponible == false && BotonEspacio5.disponible == true)
        {
            panel.SetActive(true);
            panel2.SetActive(false);
            audiosrc.PlayOneShot(clipCorrecto);
            MenuPrincipal.finEjecutivo = true;
        }
        else
        {
            panel.SetActive(false);
            panel2.SetActive(true);
            audiosrc.PlayOneShot(clipIncorrecto);
            MenuPrincipal.finEjecutivo = false;
        }
        if (CasosParqueadero.caso4 == true && BotonEspacio1.disponible == false && BotonEspacio2.disponible == true
            && BotonEspacio3.disponible == false && BotonEspacio4.disponible == true && BotonEspacio5.disponible == false)
        {
            panel.SetActive(true);
            panel2.SetActive(false);
            audiosrc.PlayOneShot(clipCorrecto);
            MenuPrincipal.finEjecutivo = true;
        }
        if (CasosParqueadero.caso3 == true && BotonEspacio1.disponible == true && BotonEspacio2.disponible == true
            && BotonEspacio3.disponible == false && BotonEspacio4.disponible == false && BotonEspacio5.disponible == false)
        {
            panel.SetActive(true);
            panel2.SetActive(false);
            audiosrc.PlayOneShot(clipCorrecto);
            MenuPrincipal.finEjecutivo = true;
        }
        if (CasosParqueadero.caso2 == true && BotonEspacio1.disponible == false && BotonEspacio2.disponible == true
            && BotonEspacio3.disponible == true && BotonEspacio4.disponible == true && BotonEspacio5.disponible == false)
        {
            panel.SetActive(true);
            panel2.SetActive(false);
            audiosrc.PlayOneShot(clipCorrecto);
            MenuPrincipal.finEjecutivo = true;
        }
        if (CasosParqueadero.caso1 == true && BotonEspacio1.disponible == true && BotonEspacio2.disponible == false
            && BotonEspacio3.disponible == false && BotonEspacio4.disponible == false && BotonEspacio5.disponible == true)
        {
            panel.SetActive(true);
            panel2.SetActive(false);
            audiosrc.PlayOneShot(clipCorrecto);
            MenuPrincipal.finEjecutivo = true;
        }
    }
}
