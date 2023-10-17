using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class FileSystem : MonoBehaviour
{
    public GameObject obj;
    public bool isSavingPosition = false;
    void createFile()
    {
        //1) Acceder al path del archivo
        string fileName = "example";
        string extension = ".txt";
        
        string path = Application.dataPath + "/Resourses/" + fileName + extension;
        //2)Crear un archivo, si no existe otro con el mismo nombre 
        if (!File.Exists(path))
        {
            //3)Escribir dentro del archivo
            File.WriteAllText(path, "Hola");
        }
        //4)Guardar o almacenar el contenido del archivo
        string data = "Login Date: " + System.DateTime.Now + "\n";

        //5)Agregar la información al archivo
        File.AppendAllText(path, data);
    }

    void SaveObjectPosition(Transform _objTransform)
    {
        //1) Acceder al path del archivo
        string fileName = "example";
        string extension = ".txt";

        string path = Application.dataPath + "/Resourses/" + fileName + extension;
        //2)Crear un archivo, si no existe otro con el mismo nombre 
        if (!File.Exists(path))
        {
            //3)Escribir dentro del archivo
            File.WriteAllText(path, "Hola");
        }
        //4)Guardar o almacenar el contenido del archivo
        string data = "Position: " + "(" + _objTransform.position.x.ToString() + ","
                                         + _objTransform.position.y.ToString() + ","
                                         + _objTransform.position.z.ToString() + ","
                                         + "\n";
        //5)Agregar la información al archivo
        File.AppendAllText(path, data);
    }

    string ReadFile(string _fileName, string _extension)
    {
        //1)Acceder al path del archivo
        string path = Application.dataPath + "/Resourses/" + _fileName + _extension;
        //Si el archivo existe, dame su info
        string data = "";
        if (File.Exists(path))
        {
            data = File.ReadAllText(path); 
        }
        
        return data;
    }

    void Start()
    {
        //createFile();
        //1) Guarda la posicion en un nuevo archivo
        SaveObjectPosition(obj.transform);
        //2) Lee l ainformacion de ese archivo
        string data = ReadFile("example", "_txt");
        Debug.Log("Informacion del archivo: \n" + data);
       
        //3) Asigna esos datos en un nuevo objeto
       

    }

    Vector3 ParseStringToVector3(string input)
    {
        Vector3 result = Vector3.zero;
        string[] components = input.Split(',');

        if (components.Length == 3)
        {
            //result = new Vector3(float.Parse(components[0], float.Parse(components[1], float.Parse(components[2]));
            if (float.TryParse(components[0], out float x) &&
                float.TryParse(components[0], out float y) &&
                float.TryParse(components[0], out float z))
            {
                result = new Vector3(x, y, z);
            }
            else
            {
                Debug.LogError("No se pudieron convertir todos los componentes a numeros.");
            }
        }
        else
        {
            Debug.LogWarning("El formato del string no es valido.");
        }
        return result;
    }

    void Update()
    {
        if (isSavingPosition)
        {
           SaveObjectPosition(obj.transform);
        }
    }
}