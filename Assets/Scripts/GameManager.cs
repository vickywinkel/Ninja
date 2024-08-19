using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int vidas = 3;
    private int puntos;
    private int mayorPuntaje;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PerderVida()
    {
        vidas--;
        Debug.Log("Vidas restantes: " + vidas);

        if (vidas == 0)
        {
            Debug.Log("Perdiste :(");
            SceneManager.LoadScene("Perdiste"); 
        }
    } 

    public void SumarPuntos(int puntosGanados)
    {
        puntos += puntosGanados;
        Debug.Log("Puntos: " + puntos);
    }
}
