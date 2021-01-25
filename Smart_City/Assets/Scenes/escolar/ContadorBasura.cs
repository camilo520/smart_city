using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorBasura : MonoBehaviour
{

    public Text contador;
    public Text contador2;
    public Text contador3;
    public Text estado;
    public Text estado2;
    public Text estado3;
    private bool playAudio=false;
    public static float tiempo = 0f;
    public static float tiempo2 = 0f;
    public static float tiempo3 = 0f;
    public GameObject panel2;
    private bool desbordado;
    public static AudioClip clipIncorrecto;
    public AudioSource audiosrc;

    // Start is called before the first frame update
    void Start()
    {
        tiempo = 0f;
        tiempo2 = 0f;
        tiempo3 = 0f;
        desbordado = false;
        playAudio = false;
        //contador.text = " " + tiempo + " Kg";
        //contador2.text = " " + tiempo2 + " Kg";
        //contador3.text = " " + tiempo3 + " Kg";
        estado.text = "";
        estado2.text = "";
        estado3.text = "";
        StartCoroutine(contaminacion());
        StartCoroutine(contaminacion2());
        StartCoroutine(contaminacion3());
        panel2.SetActive(false);
        clipIncorrecto = Resources.Load<AudioClip>("sound_failder");
        audiosrc.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //---------------------tiempo1-------------

        if (tiempo>=5 && tiempo <= 14 )
        {
            estado.text = "Bote medio vacio";
            desbordado = false;
        }
        else if (tiempo >= 15 && tiempo <= 25)
        {
            estado.text = "Bote medio lleno";
            desbordado = false;
        }
        else if(tiempo >=26)
        {
            estado.text = "Bote lleno";
            desbordado = false;

        }
        else
        {
            estado.text = "";
        }

        


        //---------------------tiempo2-------------

        if (tiempo2 >= 5 && tiempo2 <= 14)
        {
            estado2.text = "Bote medio vacio";
            desbordado = false;
        }
        else if (tiempo2 >= 15 && tiempo2 <= 25)
        {
            estado2.text = "Bote medio lleno";
            desbordado = false;
        }
        else if (tiempo2 >= 26)
        {
            estado2.text = "Bote lleno";
            desbordado = false;
        }
        else
        {
            estado2.text = "";
            desbordado = false;
        }

        
        //---------------------tiempo3-------------

        if (tiempo3 >= 5 && tiempo3 <= 14)
        {
            estado3.text = "Bote medio vacio";
            desbordado = false;
        }
        else if (tiempo3 >= 15 && tiempo3 <= 25)
        {
            estado3.text = "Bote medio lleno";
            desbordado = false;
        }
        else if (tiempo3 >= 26)
        {
            estado3.text = "Bote lleno";
            desbordado = false;
        }
        else
        {
            estado3.text = "";
            
        }

        if (tiempo >= 40 || tiempo2 >= 40 || tiempo3 >= 40 )
        {
            desbordado = true;
            panel2.SetActive(true);
            MenuPrincipal.finComercial = false;
            if (playAudio==false)
            {
                audiosrc.PlayOneShot(clipIncorrecto);
                playAudio = true;
            }
            
            
        }

    }

    IEnumerator contaminacion()
    {
        while (BotonRecoger.b==false && desbordado==false)
        {
                    if (DropSlotComercial1.encasilla == true && DropSlotComercial2.encasilla == true && DropSlotComercial3.encasilla == true)
                    {
                        tiempo += Random.Range(2, 5);
                        contador.text = " " + tiempo.ToString("f0") + " Kg";

                    }
                    else
                    {

                    }
                    yield return new WaitForSeconds(2);
            
            
        }
        
    }

    IEnumerator contaminacion2()
    {
        while (BotonRecoger2.b == false && desbordado == false)
        {
                if (DropSlotComercial1.encasilla == true && DropSlotComercial2.encasilla == true && DropSlotComercial3.encasilla == true)
                {
                    tiempo2 += Random.Range(2, 5);
                    contador2.text = " " + tiempo2.ToString("f0") + " Kg";
                }
                else
                {

                }
                yield return new WaitForSeconds(2);

            }
        }

    IEnumerator contaminacion3()
    {
        while(BotonRecoger3.b == false && desbordado == false)
            {
            if (DropSlotComercial1.encasilla == true && DropSlotComercial2.encasilla == true && DropSlotComercial3.encasilla == true)
            {
                tiempo3 += Random.Range(2, 5);
                contador3.text = " " + tiempo3.ToString("f0") + " Kg";
            }
            else
            {

            }
            yield return new WaitForSeconds(2);

        }
    }

    }


