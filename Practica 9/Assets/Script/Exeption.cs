using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Exeption : MonoBehaviour
{
  int divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("No se puede dividir por 0.");
        }
        return a / b;
    }

    int GetArrayValue(int[] array, int index)
    {
        if(index < 0|| index >= array.Length)
        {
            throw new IndexOutOfRangeException("Indíce fuera de rango. Checate");
        }
        return array[index];
    }

    int CastStringToInt(string _str)
    {
        return int.Parse(_str);
    }
    void Start()
    {
        //Divide entre cero
        try
        {
            int result = divide(10, 0);
            Debug.Log("Resultado de la división: " + result);
        }
        catch (DivideByZeroException exception)
        {
            Debug.Log("Error División por cero: " + exception.Message);
        }

        try
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int val = GetArrayValue(array, 7);
            Debug.Log("Valor obtenido: " + val);
        }
        catch (IndexOutOfRangeException ex2)
        {
            Debug.Log("Error: Indice fuera de rango. Detalles: " + ex2.Message);
        }

        try
        {
            string str = "255b";
            int result = CastStringToInt(str);
            Debug.Log("Numero convertido: " + result);
        }
        catch(FormatException ex3)
        {
            Debug.Log("Error: Formato incorrecto. Detalle: " + ex3.Message);
        }
        catch(Exception ex4)
        {
            Debug.LogError("Error general. Detalles: " + ex4.Message);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
