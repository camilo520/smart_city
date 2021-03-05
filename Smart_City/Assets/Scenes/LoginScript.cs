using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginScript : MonoBehaviour
{
    public InputField login;
    public InputField pass;
    public Text aviso;
    public List<Usuarios> lista;

    public string usuario1;
    public string contraseña1;
    public string usuario2;
    public string contraseña2;
    public string usuario3;
    public string contraseña3;
    public string usuario4;
    public string contraseña4;

    public static int id = 0;

    // Start is called before the first frame update
    void Start()
    {
        usuario1 = "usuario1";
        usuario2 = "usuario2";
        usuario3 = "usuario3";
        usuario4 = "usuario4";
        contraseña1 = "11111";
        contraseña2 = "22222";
        contraseña3 = "33333";
        contraseña4 = "44444";
        id = 0;

        aviso.text = "";
 
        lista = new List<Usuarios>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ID: " + LoginScript.id);
        foreach (var a in lista)
        {
            Debug.Log("Usuario: " + a.User + " Contraseña: " + a.Pass);
        }
    }

    public void botonLog()
    {
        if(login.text.ToString().Equals(usuario1.ToString()) && pass.text.ToString().Equals(contraseña1.ToString()))
        {
            id = 1;
            SceneManager.LoadScene("SampleScene");
        }

        if (login.text.ToString().Equals(usuario2.ToString()) && pass.text.ToString().Equals(contraseña2.ToString()))
        {
            id = 2;
            SceneManager.LoadScene("SampleScene");
        }

        if (login.text.ToString().Equals(usuario3.ToString()) && pass.text.ToString().Equals(contraseña3.ToString()))
        {
            id = 3;
            SceneManager.LoadScene("SampleScene");
        }

        if (login.text.ToString().Equals(usuario4.ToString()) && pass.text.ToString().Equals(contraseña4.ToString()))
        {
            id = 4;
            SceneManager.LoadScene("SampleScene");
        }
        /*
        foreach (var a in lista)
        {
            if (a.User.Equals(login.text.ToString()) && a.Pass.Equals(pass.text.ToString()))
            {
                SceneManager.LoadScene("SampleScene");
            }
            else
            {
                StartCoroutine(avisoS());
            }
        }

        if (login.text.ToString().Equals("") && pass.text.ToString().Equals(""))
        {
            StartCoroutine(camposVacios());
        }*/
    }

    public void botonReg()
    {
        /*
        if (!login.text.ToString().Equals("") && !pass.text.ToString().Equals(""))
        {
            var usuario1 = new Usuarios();

            usuario1.User = login.text.ToString();
            usuario1.Pass = pass.text.ToString();
            lista.Add(usuario1);
        }
        else
        {
            StartCoroutine(avisoS());
        }*/




    }

    public void botonDel()
    {
    }

    IEnumerator avisoS()
    {
        aviso.text = "Usuario/Contraseña Incorrecta";

        yield return new WaitForSeconds(2);

        aviso.text = "";

        yield return new WaitForSeconds(2);

    }

    IEnumerator camposVacios()
    {
        aviso.text = "Llena todos los campos";

        yield return new WaitForSeconds(2);

        aviso.text = "";

        yield return new WaitForSeconds(2);

    }


}
