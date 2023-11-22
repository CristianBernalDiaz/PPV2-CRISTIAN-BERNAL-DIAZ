using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Cainos.PixelArtTopDown_Basic;

public class Excepciones : MonoBehaviour
{
    public GameObject Glow;

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
        if (index < 0 || index >= array.Length)
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
            try
            {
                if (result < 0)
                {
                    throw new Exception("Error: No puedes tener un valor negativo a zero en una división");
                }
            }
            catch (Exception ex9)
            {
                Debug.LogError(ex9.Message);
            }
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
        catch (FormatException ex3)
        {
            Debug.Log("Error: Formato incorrecto. Detalle: " + ex3.Message);
        }
        catch (Exception ex4)
        {
            Debug.LogError("Error general. Detalles: " + ex4.Message);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            try
            {
                if (collision.GetComponent<TopDownCharacterController>().id == 1)
                {
                    Glow.SetActive(true);
                }
                else
                {
                    throw new Exception("You dont the key..., looser xD");
                }
            }
            catch (Exception ex)
            {
                Debug.Log("Game: " + ex.Message);
            }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            transform.parent.GetChild(0).gameObject.SetActive(false);
        }
    }


    void Update()
    {

    }
}
