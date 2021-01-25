using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ComprobarApartamentos : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;
    public static AudioClip clipCorrecto;
    public static AudioClip clipIncorrecto;
    public AudioSource audiosrc;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        panel2.SetActive(false);
        clipCorrecto = Resources.Load<AudioClip>("succes_sound2");
        clipIncorrecto = Resources.Load<AudioClip>("sound_failder");
        audiosrc.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void comprobar()
    {
        if (SliderCasas1.porc <= 65)
        {
            Debug.Log("Sisas");
            panel.SetActive(true);
            panel2.SetActive(false);
            MenuPrincipal.finApartamento = true;
            audiosrc.PlayOneShot(clipCorrecto);
        }

        else
        {
            Debug.Log("Nonas");
            panel.SetActive(false);
            panel2.SetActive(true);
            MenuPrincipal.finApartamento = false;
            audiosrc.PlayOneShot(clipIncorrecto);
        }
    }
    }
