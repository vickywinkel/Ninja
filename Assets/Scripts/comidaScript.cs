using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comida : MonoBehaviour
{
    public GameObject mitades;
    public GameObject entera;
    
    public int puntajeC;

    private float tiempodestr = 3.5f;
    private bool estaCortada = false;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CortarFruta();
        }
        //if (vida == 0)
        //{
          //  Debug.Log("Perdiste :(");
        //}
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "piso")
        {
            DestruyoObjeto();
            Debug.Log("pisoo");
            if (estaCortada == false)
            {
                if (gameObject.tag != "plato")
                {
                    //vida = vida - 1;
                    estaCortada = true; 
                    Debug.Log("perdiste una vida");
                    gameManager.PerderVida();
                }
            }
        }
        // Comprueba que la colisión es con el objeto deseado 
        if (collision.gameObject.tag == "GameController")
        {
            CortarFruta();
            Debug.Log("collision");
            if (gameObject.tag == "plato")
            {
                Debug.Log("perdiste");
            }
        }
    }


    void CortarFruta()
    {
            //Se desactiva la fruta entera y se activan las mitades
            //mitades.transform.position = entera.transform.position;
            //mitades.transform.rotation = entera.transform.rotation;
            mitades.SetActive(true);
            entera.SetActive(false);
            estaCortada = true;
            gameManager.SumarPuntos(puntajeC);
    }

    void DestruyoObjeto()
    {
        Destroy(gameObject, tiempodestr);
    }

}
