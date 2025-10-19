using UnityEngine;

public class Substraction : MonoBehaviour
{
        [SerializeField] private int numero;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         Debug.Log("Iniciando cuenta atrás desde: " +numero);

        for (int i = 1; i <= numero; i++)
        {
            int n = numero - i;
             Debug.Log(n);
        }
    }

}
