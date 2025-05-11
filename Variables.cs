using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public float velocidad = 0.5f;
    // Ejercicio 2
    public float num1 = 10.0f;
    public float num2 = 5.0f;
    // Ejercicio 3
    private string cadena_1 = "Hola";
    private string cadena_2 = "mundo¡";
    // Ejercicio 4
    private bool esSumaPar;
    int num3 = 5;
    int num4 = 7;



    void Start()
    {
        // Ejercicio_1();
        //Ejercicio_2();
        //Ejercicio_3();
        //Ejercicio_4();
        Ejercicio_5();
    }

    // Ejerciicios____________________________________
 
    void Ejercicio_1()
    {
        // Imprime por consola el valo de la variable velocidad
        Debug.Log("La velocidad es: " + velocidad);
    }

    void Ejercicio_2()
    {
        // Suma
        float suma = num1 + num2;
        Debug.Log("La suma de los números es: "+ suma);

        // Resta
        float resta = num1 - num2;
        Debug.Log("La resta de los números es: "+ resta);

        //multiplicación
        float multiplicacion = num1 * num2;
        Debug.Log("La multiplicacion de los números es: " + multiplicacion);

        // División
        float division = num1 / num2;
        Debug.Log("La división de los números es: " + division);
    }

    void Ejercicio_3 ()
    {
        string resultado = cadena_1 +" "+ cadena_2;
        Debug.Log(resultado);
    }

    void Ejercicio_4()
    {
        int suma = num3 + num4;
        if ( (suma % 2) == 0)
        {
            esSumaPar = true;
        }
        else
        {
            esSumaPar = false;
        }

        Debug.Log("¿La suma es par? " + esSumaPar);
    }

    void Ejercicio_5()
    {
        // Obtiene el día actual de la semana
        DayOfWeek diaDeLasemana = DateTime.Now.DayOfWeek;

        // Verifica si hoy es Jueves
        if(diaDeLasemana == DayOfWeek.Thursday)
        {
            // Muestra el mensaje si es Jueves
            Debug.Log("Hoy es Jueves");
        }
        else
        {
            // Muestra el mensaje si no es Jueves
            Debug.Log("Hoy no es Jueves");
        }
    }

}
