using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonRegar1 : MonoBehaviour
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
        ContadorHumedad.verdadero=false;
        //Debug.Log("contador1 " + contador);
    }
}
