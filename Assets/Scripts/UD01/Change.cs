using UnityEngine;

public class Change : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Array de 5 números enteros, todos con valor 1
        int[] numbers = { 1, 1, 1, 1, 1 };  

        // Con Debug y .Length muestro cuántos elementos tiene el array
        Debug.Log("Número de elementos del array: " + numbers.Length);

        // Cambio la primera y la última posición por el número 42
        numbers[0] = 42; // primera posición
        numbers[4] = 42; // última posición (posición 4 porque el índice empieza en 0)

        // Imprimo en consola los valores actuales del array
        
        for (int i = 0; i<numbers.Length ; i++ ){
        
                Debug.Log("Valor en posición " + i + ": "+ numbers[i]);

        
        }
    }

}
