using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_Metodos : MonoBehaviour
{
   
    public int numero; // Variable p�blica que contiene el n�mero a calcular su factorial
                       // esta variable ser� visible y edtable en el inspector de Unty

    private void Awake()
    {
        //Ejerciciio 7  Este m�todos e llama cuando se instancia el script y antes de que se llame al m�todo Start
        Debug.Log("Awake: este mensaje se escribe imprime antes de Start");
    }

    private void Start()
    {
        //CalculaFactorial();  // Ejercicio_6
        // Este m�todo se llama al inicio del juego, despu�s de que Awake haya sido llamado
        Debug.Log("Start: este mensaje se escribe imprime al iniciar dle juego");

    }

    void CalculaFactorial()
    {
        int factorial = 1;

        // Verificar si el n�mero es negativo
        if (numero < 0)
        {
            Debug.Log("No se puede calcular el factorial de un n�mero negativo");
            return; // Salir del m�todo si el n�meor es negativo
        }

        // Calcular el factorial usando un bucle
        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }

        // Mostrar el resultado por la consola de Unity
        Debug.Log("El factorial de  " + numero + " es: " + factorial);
    }


}
