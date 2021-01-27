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
    public static AudioClip clipCorrecto;
    public AudioSource audiosrc;
    private bool playAudio = false;
    private bool playAudio2 = false;
    private bool playAudio3 = false;
    private bool playAudio4 = false;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = humedadB.GetComponent<Button>();
        btn.onClick.AddListener(casos);

        caso = 3;
        c1 = false;
        c2 = false;
        c3 = false;
        CallRestService.call = false;
        panelCorrecto.SetActive(false);
        MenuPrincipal.finCasa = false;

        clipCorrecto = Resources.Load<AudioClip>("succes_sound2");
        audiosrc.GetComponent<AudioSource>();
        //StartCoroutine(correctos());
    }

    // Update is called once per frame
    void Update()
    {
        if(c1==true && c2 == true && c3 == true)
        {
            panelCorrecto.SetActive(true);
            MenuPrincipal.finCasa = true;
            if (playAudio == false)
            {
                audiosrc.PlayOneShot(clipCorrecto);
                playAudio = true;
            }
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
            if (playAudio2 == false)
            {
                playAudio2 = true;
            }
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
            if (playAudio3 == false)
            {
                playAudio3 = true;
            }
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
            if (playAudio4 == false)
            {
                playAudio4 = true;
            }
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
