
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class SaveSystem : MonoBehaviour
{
    public static void saveUser(Usuarios usuario)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path =Application.persistentDataPath + "/usuario.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        UsuariosData data = new UsuariosData(usuario);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static UsuariosData loadUser()
    {
        string path = Application.persistentDataPath + "/usuario.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            UsuariosData data= formatter.Deserialize(stream) as UsuariosData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("El archivo de guardado no se encuentra en: " + path);
            return null;
        }

    }
}
