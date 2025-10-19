using UnityEngine;

public class Change : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Array de 5 n�meros enteros, todos con valor 1
        int[] numbers = { 1, 1, 1, 1, 1 };  

        // Con Debug y .Length muestro cu�ntos elementos tiene el array
        Debug.Log("N�mero de elementos del array: " + numbers.Length);

        // Cambio la primera y la �ltima posici�n por el n�mero 42
        numbers[0] = 42; // primera posici�n
        numbers[4] = 42; // �ltima posici�n (posici�n 4 porque el �ndice empieza en 0)

        // Imprimo en consola los valores actuales del array
        
        for (int i = 0; i<numbers.Length ; i++ ){
        
                Debug.Log("Valor en posici�n " + i + ": "+ numbers[i]);

        
        }
    }

}
