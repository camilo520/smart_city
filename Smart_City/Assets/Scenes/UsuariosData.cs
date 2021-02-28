using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UsuariosData : MonoBehaviour
{
    public string user;
    public string pass;

    public UsuariosData(Usuarios usuario)
    {
        user = usuario.User;
        pass = usuario.Pass;
    }
}
