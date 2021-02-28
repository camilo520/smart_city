using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Usuarios : MonoBehaviour
{


    public string User { get; set; }
    public string Pass { get; set; }

    void Start()
    {
        User = "loca";
        Pass = "monda";
    }


    public void SaveUser()
    {
        SaveSystem.saveUser(this);
    }

    public void LoadUser()
    {
        UsuariosData data =SaveSystem.loadUser();
        User = data.user;
        Pass = data.pass;
    }

}
