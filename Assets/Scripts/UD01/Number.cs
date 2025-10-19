using UnityEngine;

public class Number : MonoBehaviour
{
    
    [SerializeField] private int numero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         int result = Increment(numero);
        Debug.Log("El número incrementado es: " + result);
    }

    private int Increment(int n)
    {
        n = n + 1;
        return n;
    }
}
