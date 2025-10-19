using UnityEngine;

public class Logic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         // Array de tres valores booleanos (verdadero/falso)
        bool[] valoresLogicos = { false, false, false };

        // Primer valor (posición 0) como verdadero
        valoresLogicos[0] = true;

        // En consola se muestra el valor de cada posición
        Debug.Log("Valor en posición 0: " + valoresLogicos[0]);
        Debug.Log("Valor en posición 1: " + valoresLogicos[1]);
        Debug.Log("Valor en posición 2: " + valoresLogicos[2]);
    }

}
