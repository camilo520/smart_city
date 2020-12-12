using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonCerarPanel : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    public void cerrarPanel(string scene)
    {
        Application.LoadLevel(scene);
        panel.SetActive(false);
    }
}
