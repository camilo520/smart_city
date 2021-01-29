using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TemperaturaCasas : MonoBehaviour
{
    private int intelligence;
    public Text avisoCaso;
    public GameObject panelCorrecto;
    public GameObject panelIncorrecto;
    public GameObject dia;
    public GameObject noche;
    public GameObject lamparasDia;
    public GameObject lamparasNoche;
    public static bool light=false;
    private bool caso2;
    private bool caso1;
    public static AudioClip clipCorrecto;
    public static AudioClip clipIncorrecto;
    public AudioSource audiosrc;
    //public Material mat;

    // Start is called before the first frame update
    void Start()
    {
        panelCorrecto.SetActive(false);
        panelIncorrecto.SetActive(false);
        dia.SetActive(false);
        lamparasDia.SetActive(false);
        lamparasNoche.SetActive(false);
        noche.SetActive(false);
        caso2 = false;
        caso1 = false;
        intelligence = Random.Range(1,3);
        Greet();
        clipCorrecto = Resources.Load<AudioClip>("succes_sound2");
        clipIncorrecto = Resources.Load<AudioClip>("sound_failder");
        audiosrc.GetComponent<AudioSource>();
        //RenderSettings.skybox = mat;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void comprobarCaso()
    {
        if(caso2==true && BotonesSYS.temp1==20 || BotonesSYS.temp1 ==21 &&
            BotonesSYS2.temp2 == 20 || BotonesSYS2.temp2 == 21 && BotonesSYS3.temp3 == 20 || BotonesSYS3.temp3 == 21)
        {
            panelCorrecto.SetActive(true);
            panelIncorrecto.SetActive(false);
            audiosrc.PlayOneShot(clipCorrecto);
            MenuPrincipal.finCasa = true;
        }
        if (caso1 == true && BotonesSYS.temp1>=15 && BotonesSYS.temp1<=17 &&
            BotonesSYS2.temp2 >= 15 && BotonesSYS2.temp2 <= 17 && BotonesSYS3.temp3 >= 15 && BotonesSYS3.temp3 <= 17)
        {
            panelCorrecto.SetActive(true);
            panelIncorrecto.SetActive(false);
            MenuPrincipal.finCasa = true;
            audiosrc.PlayOneShot(clipCorrecto);
        }
        else
        {
            panelIncorrecto.SetActive(true);
            panelCorrecto.SetActive(false);
            MenuPrincipal.finCasa = false;
            audiosrc.PlayOneShot(clipIncorrecto);
        }
        
    }

    void Greet()
    {
        switch (intelligence)
        {
            case 2:
                Debug.Log("caso 2");
                caso2 = true;
                light = false;
                avisoCaso.text = "Temperatura ideal durante el dia";
                dia.SetActive(true);
                lamparasDia.SetActive(true);
                noche.SetActive(false);
                lamparasNoche.SetActive(false);
                break;
            case 1:
                Debug.Log("caso 1");
                caso1 = true;
                light = true;
                noche.SetActive(true);
                lamparasNoche.SetActive(true);
                dia.SetActive(false);
                lamparasDia.SetActive(false);
                avisoCaso.text = "Temperatura ideal durante la noche";
                break;
            default:
                avisoCaso.text = ("Incorrect intelligence level.");
                break;
        }
    }
}
