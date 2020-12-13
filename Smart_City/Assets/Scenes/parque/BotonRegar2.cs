using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonRegar2 : MonoBehaviour
{
    public Button recogio;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = recogio.GetComponent<Button>();
        btn.onClick.AddListener(recoger);

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void recoger()
    {
        if (ContadorHumedad.tiempo2 > 700f && ContadorHumedad.tiempo2 <= 1023f)
        {
            ContadorHumedad.verdadero2 = false;
        }
        //Debug.Log("contador1 " + contador);
    }
}
