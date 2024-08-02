using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tirarscript : MonoBehaviour
{
    public GameObject[] comidas; //creamos el array
    public GameObject comidaAzar;



    private int Xmix = -3;
    private int Xmax = 3;


    private int Zmix = 4;
    private int Zmax = 8;




    public Vector3 newPosition; //cordenadas prueba para instanciar 



    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < comidas.Length; i++) //desactiva todos los objetos del array
        {
            comidas[i].SetActive(false); 
        }


        GenerarRandom();

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
        newPosition = new Vector3(randomX, 0, randomz); // creo la posicion donde se va a generar con un random X y un random Z

        
        GameObject clon =  Instantiate(comidaAzar, newPosition, Quaternion.identity); // instanto el prefab
        clon.SetActive(true);

    }

    
}
