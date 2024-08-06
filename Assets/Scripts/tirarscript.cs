using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tirarscript : MonoBehaviour
{
    public GameObject[] comidas; //creamos el array
    public GameObject comidaAzar;



    private float Xmix = -1.31f;
    private float Xmax = 1.31f;


    private float Zmix = 0.5f;
    private float Zmax = 1.11f;


    public Vector3 newPosition; //cordenadas prueba para instanciar 


    float freq = 4;

    public float thrust = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < comidas.Length; i++) //desactiva todos los objetos del array
        {
            comidas[i].SetActive(false);
        }


        InvokeRepeating(nameof(GenerarRandom), 0, freq);

    }




    // Update is called once per frame
    void Update()
    {


    }

    void GenerarRandom() //funcion para q aparezca un objeto random
    {
        int azar = Random.Range(0, comidas.Length);
        comidaAzar = comidas[azar];


        float randomX = Random.Range(Xmix, Xmax); // genero random una posicion en X donde quiero que se genere
        float randomz = Random.Range(Zmix, Zmax);// genero random una posicion en Z donde quiero que se genere
        newPosition = new Vector3(randomX, 1.5f, randomz); // creo la posicion donde se va a generar con un random X y un random Z


        GameObject clon = Instantiate(comidaAzar, newPosition, Quaternion.identity); // instanto el prefab
        clon.SetActive(true);

        //clon.transform.position = newPosition;   
        Rigidbody rb = clon.GetComponent<Rigidbody>(); // Obtener el Rigidbody del objeto instanciado
        if (rb != null)
        {
            // Aplicar fuerza al Rigidbody
            rb.AddForce(thrust * Vector3.up, ForceMode.Impulse);
        }
    }

}
