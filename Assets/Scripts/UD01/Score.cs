using UnityEngine;

public class Score : MonoBehaviour
{

    [SerializeField] private int puntuacion;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         CheckScore(puntuacion);
    }

    
     private void CheckScore(int puntuacion)
    {
        if (score >= 45)
        {
            Debug.Log("�Has alcanzado la puntuaci�n necesaria!");
        }
        else
        {
            Debug.Log("No has llegado a la puntuaci�n necesaria.");
        }
    }
}
