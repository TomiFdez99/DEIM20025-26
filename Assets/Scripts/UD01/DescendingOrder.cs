using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    
    [SerializeField] private int a, b, c;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         if (a >= b && b >= c)
        {
            Debug.Log("Los n�meros est�n en orden decreciente.");
        }
        else
        {
            Debug.Log("Los n�meros NO est�n en orden decreciente.");
        }
    }

}
