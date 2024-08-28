using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoDisparo : MonoBehaviour
{
    public Transform puntoDisparoTR;
    public float thrust;
    public float fuerza;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Disparar(GameObject comidaAzar)
    {
        GameObject clon = Instantiate(comidaAzar, puntoDisparoTR.position, Quaternion.identity); // instanto el prefab
        clon.SetActive(true);

        //clon.transform.position = newPosition;   
        Rigidbody rb = clon.GetComponentInChildren<Rigidbody>(); // Obtener el Rigidbody del objeto instanciado
        if (rb != null)
        {
            // Aplicar fuerza al Rigidbody
            rb.AddForce(thrust * puntoDisparoTR.up, ForceMode.Impulse); // impulso el objeto hacia arriba
            rb.AddForce(fuerza * -puntoDisparoTR.forward, ForceMode.Impulse); // impuso el objeto hacia atras, hacia donde estoy yo
        }
    }
}
