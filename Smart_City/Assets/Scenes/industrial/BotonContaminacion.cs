using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonContaminacion : MonoBehaviour
{
    public Button recogio;
    public static bool alerta;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = recogio.GetComponent<Button>();
        btn.onClick.AddListener(recoger);
        alerta = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void recoger()
    {

        if (ContadorContaminacion.contaminacion >= 168f && ContadorContaminacion.contaminacion <= 207f && CasosIndustrial.caso3==true)
        {
            alerta = true;
            Debug.Log("caso3");
        }
        if(ContadorContaminacion.contaminacion >= 487f && ContadorContaminacion.contaminacion <=797f && CasosIndustrial.caso2==true)
        {
            alerta = true;
            Debug.Log("caso2");
        }
        if (ContadorContaminacion.contaminacion >= 678f && ContadorContaminacion.contaminacion <= 1221 && CasosIndustrial.caso1==true)
        {
            alerta = true;
            Debug.Log("caso1");
        }
    }
}
