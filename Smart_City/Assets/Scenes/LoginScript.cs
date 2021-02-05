using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginScript : MonoBehaviour
{
    public InputField login;
    public InputField pass;
    public Text aviso;
    // Start is called before the first frame update
    void Start()
    {
        aviso.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void botonLog()
    {
        if (login.text.Equals("juanpis") && pass.text.Equals("12345"))
        {
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            StartCoroutine(avisoS());
        }
    }

    IEnumerator avisoS()
    {
        aviso.text = "Usuario/Contraseña Incorrecta";

        yield return new WaitForSeconds(2);

        aviso.text = "";

        yield return new WaitForSeconds(2);

    }
}
