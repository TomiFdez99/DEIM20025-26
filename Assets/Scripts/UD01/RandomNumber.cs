using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    
    // Array de 5 cadenas de texto con predicciones 
        string[] predicciones = {
            "Tendr�s un �and� de mascota.",
            "Conocer�s a Julio Iglesias.",
            "Aprender�s a tocar el therem�n.",
            "Viajar�s a Pernambuco.",
            "Lograr�s dormir 8 horas seguidas."
        };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Genero un n�mero aleatorio entre 0 y 4
        int randomIndex = Random.Range(0, 5);

        // Muestro en consola la predicci�n aleatoria
        Debug.Log("Predicci�n del futuro: " + predicciones[randomIndex]);
    }
   
}
