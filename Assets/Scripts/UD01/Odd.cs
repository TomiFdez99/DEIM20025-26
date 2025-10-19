using UnityEngine;

public class Odd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       for (int i = 0; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        } 
    }
    //El símbolo % obtiene el resto de una división. Si dividimos un número entre 2 y el resto es distinto de 0 (!= 0), el número es impar.
}
