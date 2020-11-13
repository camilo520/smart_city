using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ComprobarApartamentos : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        panel2.SetActive(false);
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
        }

        else
        {
            Debug.Log("Nonas");
            panel.SetActive(false);
            panel2.SetActive(true);
        }
    }
    }
