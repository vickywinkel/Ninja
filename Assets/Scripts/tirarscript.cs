using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tirarscript : MonoBehaviour
{
    public GameObject[] comidas; //creamos el array
    public GameObject comidaAzar;



    private float Xmix = -2;
    private float Xmax = 2;


    private float Zmix = 15;
    private float Zmax = 14;


    public Vector3 newPosition; //cordenadas prueba para instanciar 


    float freq = 4.5f; //cada 4 segs salen los babys prefabs 

    public float thrust = 13;
    public float fuerza = 5.5f; 

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < comidas.Length; i++) //desactiva todos los objetos del array
        {
            comidas[i].SetActive(false);
        }


        InvokeRepeating(nameof(GenerarRandom), 0, freq); // ESTO DSP SE USA PARA HACER LO D AL LLEGAR A TAL PUNTAJE, AUMENTAR LA VELOCIDAD

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
        Rigidbody rb = clon.GetComponentInChildren<Rigidbody>(); // Obtener el Rigidbody del objeto instanciado
        if (rb != null)
        {
            // Aplicar fuerza al Rigidbody
            rb.AddForce(thrust * Vector3.up, ForceMode.Impulse); // impulso el objeto hacia arriba
            rb.AddForce(fuerza * Vector3.back, ForceMode.Impulse); // impuso el objeto hacia atras, hacia donde estoy yo
        }

    }
 

}
