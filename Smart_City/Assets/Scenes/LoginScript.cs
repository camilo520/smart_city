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

    // Start is called before the first frame update
    void Start()
    {
        aviso.text = "";
        lista = new List<Usuarios>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var a in lista)
        {
            Debug.Log("Usuario: " + a.User + " Contraseña: " + a.Pass);
        }
    }

    public void botonLog()
    {
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
        }
    }

    public void botonReg()
    {
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
        }




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
