using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comida : MonoBehaviour
{
    public GameObject mitad1;
    public GameObject mitad2;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "piso")
        {
            Destroy(gameObject);
        }
        // Comprueba que la colisión es con el objeto deseado (puedes especificar el tag del objeto)
        if (collision.gameObject.tag == "GameControlle")
        {
            Debug.Log("collision");
            // Obtener la posición y rotación del objeto actual
            Vector3 position = transform.position;
            Quaternion rotation = transform.rotation;

            // Instanciar los nuevos objetos en la posición del objeto original
            Instantiate(mitad1, position, rotation);
            Instantiate(mitad2, position, rotation);

            // Destruir el objeto original
            Destroy(gameObject);
        }
    }
}
