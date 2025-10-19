using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{

    [SerializeField] private int a, b, c;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         int mayor, mediano, menor;

        if (a >= b && a >= c)
        {
            mayor = a;
            if (b >= c)
            {
                mediano = b;
                menor = c;
            }
            else
            {
                mediano = c;
                menor = b;
            }
        }
        else if (b >= a && b >= c)
        {
            mayor = b;
            if (a >= c)
            {
                mediano = a;
                menor = c;
            }
            else
            {
                mediano = c;
                menor = a;
            }
        }
        else
        {
            mayor = c;
            if (a >= b)
            {
                mediano = a;
                menor = b;
            }
            else
            {
                mediano = b;
                menor = a;
            }
        }

        Debug.Log("Orden de mayor a menor: " + mayor + ", " + mediano + ", " + menor);
    }

    
}
