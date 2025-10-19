using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    //Zona de variables globales
    
    [SerializeField] private int a, b, c;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int menor, mediano, mayor;

        if (a <= b && a <= c)
        {
            menor = a;
            if (b <= c)
            {
                mediano = b;
                mayor = c;
            }
            else
            {
                mediano = c;
                mayor = b;
            }
        }
        else if (b <= a && b <= c)
        {
            menor = b;
            if (a <= c)
            {
                mediano = a;
                mayor = c;
            }
            else
            {
                mediano = c;
                mayor = a;
            }
        }
        else
        {
            menor = c;
            if (a <= b)
            {
                mediano = a;
                mayor = b;
            }
            else
            {
                mediano = b;
                mayor = a;
            }
        }

        Debug.Log("Orden de menor a mayor: " + menor + ", " + mediano + ", " + mayor);   

    }

}
