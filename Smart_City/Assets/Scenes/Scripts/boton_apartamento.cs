using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boton_apartamento : MonoBehaviour
{

    public void changescene(string scene)
    {
        Application.LoadLevel(scene);
    }
}
