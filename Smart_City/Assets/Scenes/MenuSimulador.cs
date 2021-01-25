using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSimulador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
}

    // Update is called once per frame
    void Update()
    {
        MenuPrincipal.finApartamento = false;
        MenuPrincipal.finCasa = false;
        MenuPrincipal.finComercial = false;
        MenuPrincipal.finEjecutivo = false;
        MenuPrincipal.finParque = false;
        MenuPrincipal.finIndustrial = false;
    }
}
