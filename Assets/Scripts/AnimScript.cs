using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimScript : MonoBehaviour
{
    public Animator anim;
    public PuntoDisparo puntodisparoScript; 
    void Awake()
    {
        anim = GetComponent<Animator>();
        puntodisparoScript = FindObjectOfType<PuntoDisparo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (puntodisparoScript.id == "heladera")
        {
            Debug.Log("hola");
            anim.SetBool("seTiroHeladera", true);
        }
    }
}
