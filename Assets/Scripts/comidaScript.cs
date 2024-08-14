using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comida : MonoBehaviour
{
    public GameObject mitades;
    public GameObject entera;
    
    public int puntajeC;

    private float tiempodestr = 3.5f; 
    
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
            DestruyoObjeto();
            Debug.Log("pisoo");
        }
        // Comprueba que la colisión es con el objeto deseado 
        if (collision.gameObject.tag == "GameController")
        {
            CortarFruta();
            Debug.Log("collision");
        }
    }


    void CortarFruta()
    {
            //Se desactiva la fruta entera y se activan las mitades
            mitades.transform.position = entera.transform.position;
            mitades.transform.rotation = entera.transform.rotation;
            mitades.SetActive(true);
            entera.SetActive(false);
    }

    void DestruyoObjeto()
    {
        Destroy(gameObject, tiempodestr);
    }
}
