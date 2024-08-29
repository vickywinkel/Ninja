using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tirarscript : MonoBehaviour
{
    public GameObject[] comidas; //creamos el array
    public GameObject comidaAzar;

    public PuntoDisparo[] puntosDisparo;

    private float Xmix = -2;
    private float Xmax = 2;

    private float Zmix = 15;
    private float Zmax = 14;


    public Vector3 newPosition; //cordenadas prueba para instanciar 


    float freq = 4.5f; //cada 4 segs salen los babys prefabs 

    public float thrust = 13;
    public float fuerza = 5.5f;

    public float tiempoTotal = 3f;
    private float tiempoActual = 0;
   
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        CuentaReg cuenta = gameObject.GetComponent<CuentaReg>();
        if (cuenta.empezoC == true)
        {
            InvokeRepeating(nameof(DispararDeUnPuntoAlAzar), 0, freq); // ESTO DSP SE USA PARA HACER LO D AL LLEGAR A TAL PUNTAJE, AUMENTAR LA VELOCIDAD
            cuenta.empezoC = false;
        }
   
    }

    void DispararDeUnPuntoAlAzar()
    {
        int nroAlAzar = Random.Range(0,puntosDisparo.Length);
        puntosDisparo[nroAlAzar].Disparar(GenerarRandom());
    }

    GameObject GenerarRandom() //funcion para q aparezca un objeto random
    {
        int azar = Random.Range(0, comidas.Length);
        return comidaAzar = comidas[azar];

    }
}
