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
    //El s�mbolo % obtiene el resto de una divisi�n. Si dividimos un n�mero entre 2 y el resto es distinto de 0 (!= 0), el n�mero es impar.
}
