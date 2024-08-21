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
        txt_puntos.text = GameManager.Instance.puntos.ToString();
    }

    public void empezarJuego()
    {
        SceneManager.LoadScene("juego");
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
