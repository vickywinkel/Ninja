using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comida : MonoBehaviour
{
    public GameObject mitades;
    public GameObject entera;
    
    public int puntajeC; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CortarFruta();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "piso")
        {
            Destroy(gameObject);
            Debug.Log("pisoo"); 
        }
        // Comprueba que la colisi�n es con el objeto deseado 
        if (collision.gameObject.tag == "GameController")
        {
            Debug.Log("collision");
            CortarFruta();
        }
    }


    void CortarFruta()
    {
        //Se desactiva la fruta entera y se activan las mitades
        entera.SetActive(false);
        mitades.SetActive(true);
    }
}
