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
    //Es prácticamente el mismo código que el ejercicio anterior. Cambiamos la condición a i % 2 == 0, lo que significa “el número es divisible entre 2”.

}
