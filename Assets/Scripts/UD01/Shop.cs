using UnityEngine;

public class Shop : MonoBehaviour
{
    
    [SerializeField] private int brecol;
    [SerializeField] private int patata;
    [SerializeField] private int sumaPatata;
    [SerializeField] private int restaPatata;
    [SerializeField] private int sumaBrecol;
    [SerializeField] private int restaBrecol;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        brecol = AddProduct(brecol, sumaBrecol);
        brecol = SubtractProduct(brecol, restaBrecol);
        patata = AddProduct(patata, sumaPatata);
        patata = SubtractProduct(patata, restaPatata);

        Debug.Log("Brecol final: " + brecol);
        Debug.Log("Patatas finales: " + patata);
    }

   
    private int AddProduct(int existencias, int cantidad)
    {
        existencias += cantidad;
        return existencias;
    }

    private int SubtractProduct(int existencias, int cantidad)
    {
        existencias -= cantidad;
        return existencias;
    }

}
