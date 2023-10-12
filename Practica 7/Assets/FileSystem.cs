using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class FileSystem : MonoBehaviour
{
    public GameObject obj;
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

    void Start()
    {
        createFile();
    }


    void Update()
    {
        SaveObjectPosition(obj.transform);
    }
}
