using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    
    [SerializeField] private int a, b, c;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         if (a >= b && b >= c)
        {
            Debug.Log("Los números están en orden decreciente.");
        }
        else
        {
            Debug.Log("Los números NO están en orden decreciente.");
        }
    }

}
