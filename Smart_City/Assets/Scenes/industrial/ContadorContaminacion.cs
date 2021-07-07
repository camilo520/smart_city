using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ContadorContaminacion : MonoBehaviour
{

    public Text numeroContaminacion;
    public Text avisoContaminacion1;
    public GameObject nube1;
    public GameObject nube2;
    public GameObject nube3;
    private bool playAudio=false;
    public GameObject panelCorrecto;
    public GameObject panelIncorrecto;
    public static float contaminacion;
    public static bool sepaso;
    private bool correcto;
    public static AudioClip clipCorrecto;
    public static AudioClip clipIncorrecto;
    public AudioSource audiosrc;
    public static int bajandoC;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(sumarContaminacion());
        StartCoroutine(restarContaminacion());
        numeroContaminacion.text = "";
        avisoContaminacion1.gameObject.GetComponent<Text>();
        avisoContaminacion1.text = "";
        contaminacion = 50f;
        bajandoC = 0;
        sepaso = false;
        playAudio = false;
        nube1.SetActive(false);
        nube2.SetActive(false);
        nube3.SetActive(false);
        panelCorrecto.SetActive(false);
        panelIncorrecto.SetActive(false);
        correcto = false;
        posicionHumo.humo1 = false;
        posicionHumo2.humo2 = false;
        posicionHumo3.humo3 = false;
        DropSlotIndustrial.encasilla = false;
        BotonContaminacion.alerta = false;
        clipCorrecto = Resources.Load<AudioClip>("succes_sound2");
        clipIncorrecto = Resources.Load<AudioClip>("sound_failder");
        audiosrc.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BotonContaminacion.alerta == true && correcto==false)
        {
            nube1.SetActive(true);
            nube2.SetActive(true);
            nube3.SetActive(true);
            
        }
        if (BotonContaminacion.alerta == true && posicionHumo.humo1 == true)
        {
            nube1.SetActive(false);
        }
        if (BotonContaminacion.alerta == true && posicionHumo2.humo2 == true)
        {
            nube2.SetActive(false);
        }
        if (BotonContaminacion.alerta == true && posicionHumo3.humo3 == true)
        {
            nube3.SetActive(false);
        }

        
        if (contaminacion >= 300f && CasosIndustrial.caso3==true)
        {
            panelIncorrecto.SetActive(true);
            correcto = true;
            MenuPrincipal.finIndustrial = false;
            if (playAudio == false)
            {
                audiosrc.PlayOneShot(clipIncorrecto);
                playAudio = true;
            }
        }
        if(contaminacion >= 900f && CasosIndustrial.caso2 == true)
        {
            panelIncorrecto.SetActive(true);
            MenuPrincipal.finIndustrial = false;
            correcto = true;
            if (playAudio == false)
            {
                audiosrc.PlayOneShot(clipIncorrecto);
                playAudio = true;
            }
        }
        if (contaminacion >= 1350f && CasosIndustrial.caso1 == true)
        {
            panelIncorrecto.SetActive(true);
            MenuPrincipal.finIndustrial = false;
            correcto = true;
            if (playAudio == false)
            {
                audiosrc.PlayOneShot(clipIncorrecto);
                playAudio = true;
            }
        }
        if (contaminacion < 50f)
        {
            panelCorrecto.SetActive(true);
            correcto = true;
            MenuPrincipal.finIndustrial = true;
            if (playAudio == false)
            {
                audiosrc.PlayOneShot(clipCorrecto);
                playAudio = true;
            }
        }
    }

    IEnumerator sumarContaminacion()
    {
        while (BotonContaminacion.alerta == false && correcto==false)
        {
            if (DropSlotIndustrial.encasilla == true)
            {
                contaminacion += Random.Range(25, 45);
                //numeroContaminacion.text = " " + contaminacion.ToString("f0") + " ppm";
                numeroContaminacion.text = "Revisa el dashboard para obtener información actual de la contaminación en el sector";
            }
            else
            {
            }
            yield return new WaitForSeconds(2f);
        }

    }

    IEnumerator restarContaminacion()
    {
        while (correcto==false)
        {
            if (DropSlotIndustrial.encasilla == true && BotonContaminacion.alerta == true && posicionHumo.humo1 == true && posicionHumo2.humo2 == true && posicionHumo3.humo3 == true)
            {
                bajandoC = 1;
                contaminacion -= Random.Range(25, 40);
                //numeroContaminacion.text = " " + contaminacion.ToString("f0") + " ppm";
                avisoContaminacion1.color = new Color(0, 255, 0);
                avisoContaminacion1.text = "La contaminación esta bajando";
                numeroContaminacion.text = "";
            }
            else if(DropSlotIndustrial.encasilla == true && BotonContaminacion.alerta == true && posicionHumo.humo1 == false && posicionHumo2.humo2 == false && posicionHumo3.humo3 == false)
            {
                
                avisoContaminacion1.color = new Color(255, 255, 255);
                avisoContaminacion1.text = "Elimina los restos de contaminación hacia arriba";
                numeroContaminacion.text = "";
            }
            yield return new WaitForSeconds(1);
        }

    }
}
