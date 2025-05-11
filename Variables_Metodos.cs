using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_Metodos : MonoBehaviour
{
   
    public int numero; // Variable pública que contiene el número a calcular su factorial
                       // esta variable será visible y edtable en el inspector de Unty

    private void Awake()
    {
        //Ejerciciio 7  Este métodos e llama cuando se instancia el script y antes de que se llame al método Start
        Debug.Log("Awake: este mensaje se escribe imprime antes de Start");
    }

    private void Start()
    {
        //CalculaFactorial();  // Ejercicio_6
        // Este método se llama al inicio del juego, después de que Awake haya sido llamado
        Debug.Log("Start: este mensaje se escribe imprime al iniciar dle juego");

    }

    void CalculaFactorial()
    {
        int factorial = 1;

        // Verificar si el número es negativo
        if (numero < 0)
        {
            Debug.Log("No se puede calcular el factorial de un número negativo");
            return; // Salir del método si el númeor es negativo
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
