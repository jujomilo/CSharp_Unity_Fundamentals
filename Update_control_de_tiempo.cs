using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Update_control_de_tiempo : MonoBehaviour
{
    private int contadorFotogramas = 0;

    void Update()
    {
        // Ejercicio 8 Obtiene el tiempo transcurrido desde el fotograma anterior 
        // Utilizando Tiem.deltaTime
        //float tiempoTranscurrido = Time.deltaTime;

        // Imprime el tiempo transcurrido por consola
        //Debug.Log("Tiempo transcurrido desde le fotograma anterior: " + tiempoTranscurrido);

        // Ejercicio 9 ______________________________________________________________________
        // Incrementa le contador en cada fotograma
        contadorFotogramas++;

        // Veridficar si han pasado 100 fotogramas
        if(contadorFotogramas % 100 == 0)
        {
            // Imprime le tiempo transcurrido desdele inicio dela ejecución
            float tiempoTranscurrido = Time.time;
            Debug.Log("Tiempo transcurrido cada 100 fotogramas: " + tiempoTranscurrido);
        }
    }
}
