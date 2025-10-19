using UnityEngine;

public class Week : MonoBehaviour 
{
    
    [SerializeField] private int number;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        switch(number){
        
            case 1:  Debug.Log("Lunes");
                break;
            case 2:  Debug.Log("Martes");
                break;
            case 3:  Debug.Log("Miercoles");
                break;
            case 4:  Debug.Log("jueves");
                break;
            case 5:  Debug.Log("viernes");
                break;
            case 6:  Debug.Log("Sábado");
                break;
            case 7:  Debug.Log("Domingo");
                break;
        }
    }

}
