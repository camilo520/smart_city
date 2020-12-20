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

        if (ContadorContaminacion.contaminacion >= 500f && ContadorContaminacion.contaminacion <= 800f)
        {
            alerta = true;
        }
    }
}
