using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComprobarEstrellas : MonoBehaviour
{
    public Image img1;
    public Image img2;
    public Image img3;
    public GameObject panel;
    private bool verdad = false;
    private int oportunidades = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void comprobar()
    {
        if (verdad == false && oportunidades==3)
        {
            img1.enabled = false;
            oportunidades--;
            panel.SetActive(false);
        }
        else if(verdad == false && oportunidades == 2)
        {
            img2.enabled = false;
            oportunidades--; 
            panel.SetActive(false);
        }
        else if (verdad == false && oportunidades == 1)
        {
            img3.enabled = false;
            oportunidades--;
            Debug.Log("no pudiste hacerlo de manera correcta");
            panel.SetActive(true);
        }
    }

}
