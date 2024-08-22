using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class comida : MonoBehaviour
{
    public GameObject mitades;
    public GameObject entera;

    public int puntajeC;

    private float tiempodestr = 3.5f;
    private bool estaCortada = false;
    private GameManager gameManager;

    public float radius = 8.0F;
    public float power = 20.0F;

    public float tiempoTotal = 1.5f;
    private float tiempoActual = 0;
    bool empezo = false;

    public bool cortastePlato = false;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        tiempoTotal = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CortarFruta();
            Debug.Log("collision");
            if (gameObject.tag == "plato")
            {
                cortastePlato = true;

            }
            else if (estaCortada == true)
            {
                gameManager.SumarPuntos(puntajeC);

            }
        }
        if (cortastePlato)
        {
            if (tiempoActual < tiempoTotal)
            {
                tiempoActual += Time.deltaTime;
                Debug.Log("Contando: " + tiempoActual);
            }
            else
            {
                Debug.Log("aca");
                SceneManager.LoadScene("Perdiste");
            }
        }


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
            else if (estaCortada == true)
            {
                gameManager.SumarPuntos(puntajeC);

            }
        }
    }


    void CortarFruta()
    {

        mitades.SetActive(true);
        entera.SetActive(false);
        estaCortada = true;
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
        }
    }

    void DestruyoObjeto()
    {
        Destroy(gameObject, tiempodestr);
    }

}
