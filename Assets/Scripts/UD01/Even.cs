using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }
    //Es pr�cticamente el mismo c�digo que el ejercicio anterior. Cambiamos la condici�n a i % 2 == 0, lo que significa �el n�mero es divisible entre 2�.

}
