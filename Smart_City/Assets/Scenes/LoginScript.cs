using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginScript : MonoBehaviour
{
    public InputField ID;
    public Text aviso;
    public List<Usuarios> lista;
    public static string userID;


    // Start is called before the first frame update
    void Start()
    {
        userID = "";
        lista = new List<Usuarios>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ID: " + LoginScript.userID);
    }

    public void botonLog()
    {
        
        if (ID.text.ToString().Equals(""))
        {
            StartCoroutine(camposVacios());
        }
        else
        {
            userID = ID.text.ToString();
            Debug.Log("ID: " + LoginScript.userID);
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
        aviso.text = "Llena el campo de ID";

        yield return new WaitForSeconds(2);

        aviso.text = "";

        yield return new WaitForSeconds(2);

    }


}
