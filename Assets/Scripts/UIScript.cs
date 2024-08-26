using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public TextMeshProUGUI txt_puntos;
    public TextMeshProUGUI txt_mayorpuntaje;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (txt_puntos)
        {
            txt_puntos.text = ("Puntos: " + GameManager.Instance.puntos.ToString());
        }
        if (txt_mayorpuntaje)
        {
            txt_mayorpuntaje.text = GameManager.Instance.mayorPuntaje.ToString();
        }
       
    }

    public void empezarJuego()
    {
        SceneManager.LoadScene("juego");
        GameManager.Instance.puntos = 0; 
        GameManager.Instance.vidas = 3; 
    }

    public void IrAcreditos()
    {
        SceneManager.LoadScene("creditos");
    }
    public void VolverAlMenu()
    {
        SceneManager.LoadScene("menu");
    }

}
