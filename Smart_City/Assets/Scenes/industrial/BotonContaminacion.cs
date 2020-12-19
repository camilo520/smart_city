using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonContaminacion : MonoBehaviour
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

        if (ContadorContaminacion.contaminacion >= 500f && ContadorContaminacion.contaminacion <= 800f)
        {
            ContadorContaminacion.sepaso = true;
        }

        //Debug.Log("contador1 " + contador);
    }
}
