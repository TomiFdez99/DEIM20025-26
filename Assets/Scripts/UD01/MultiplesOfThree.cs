using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
        }
    }
    //i % 3 == 0, Significa “cuando i dividido entre 3 tiene resto 0”, el bucle recorre todos los números del 0 al 100, pero solo imprime los que cumplen la condición.
}
