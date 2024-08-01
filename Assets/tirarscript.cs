using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tirarscript : MonoBehaviour
{
    public GameObject[] comidas;
    GameObject comidaAzar; 


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < comidas.Length; i++)
        {
            comidas[i].SetActive(false);
        }
        GenerarRandom();
    }




    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerarRandom()
    {
        int azar = Random.Range(0, comidas.Length);
        comidaAzar = comidas[azar];
        GameObject food = Instantiate(comidaAzar); //corregir
    }
}
