using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class espadaScript : MonoBehaviour
{
    public float tiempoTotal = 1.5f;
    private float tiempoActual = 0;
    bool empezo = false;

    // Start is called before the first frame update
    void Start()
    {
        tiempoTotal = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        // Comprueba que la colisión es con el objeto deseado 
        comida comidaScript = collision.gameObject.GetComponent<comida>();

        if (collision.gameObject.tag == "Comida")
        {
            comidaScript.CortarFruta();
            Debug.Log("collision");
            if (gameObject.tag == "plato")
            {
                if (tiempoActual < tiempoTotal)
                {
                    tiempoActual += Time.deltaTime;
                }
                else if (!empezo)
                {
                    empezo = true;
                    SceneManager.LoadScene("Perdiste");
                }
            }
            else if (comidaScript.estaCortada == true)
            {
                GameManager.Instance.SumarPuntos(comidaScript.puntajeC);
            }
        }
    }
}
