using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int vidas = 3;
    private int puntos;
    private int mayorPuntaje;
    public TextMeshProUGUI txt_puntos;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else //si instance es nulo, vacio
        {
            Instance = this; //yo soy instance --> este script
        }

        DontDestroyOnLoad(this); //para q esto se manetenga en tds las escenas 
    }


    // Update is called once per frame
    void Update()
    {
        txt_puntos.text = (puntos + " puntos");
    }

    public void PerderVida()
    {
        vidas--;
        Debug.Log("Vidas restantes: " + vidas);

        if (vidas == 0)
        {
            Debug.Log("Perdiste :(");
            ChangeScene("Perdiste"); 
        }
    } 

    public void SumarPuntos(int puntosGanados)
    {
        puntos += puntosGanados;
        Debug.Log("Puntos: " + puntos);
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
