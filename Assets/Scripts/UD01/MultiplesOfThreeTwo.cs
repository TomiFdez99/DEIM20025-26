using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }
    //&& significa “además”, lo que implica que ambas condiciones se deben cumplir al mismo tiempo. Que el número sea multiplo de 3 y de 2

}
