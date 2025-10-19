using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    
    // Array de 5 cadenas de texto con predicciones 
        string[] predicciones = {
            "Tendrás un ñandú de mascota.",
            "Conocerás a Julio Iglesias.",
            "Aprenderás a tocar el theremín.",
            "Viajarás a Pernambuco.",
            "Lograrás dormir 8 horas seguidas."
        };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Genero un número aleatorio entre 0 y 4
        int randomIndex = Random.Range(0, 5);

        // Muestro en consola la predicción aleatoria
        Debug.Log("Predicción del futuro: " + predicciones[randomIndex]);
    }
   
}
