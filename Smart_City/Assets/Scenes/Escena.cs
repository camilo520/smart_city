using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escena : MonoBehaviour
{
    public void cambiarescena(string nombreescena)
    {
        SceneManager.LoadScene(nombreescena);
    }

    public void salirescena()
    {
        Application.Quit();
    }
}
