using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logicapersonaje1 : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f; //Velocidad de movimiento de personaje
    public float velocidadRotacion = 200.0f; //Velocidad de rotacion de personaje

    private Animator anim;
    public float x, y; // indicar si nuestro personaje se mueve en los ejes

    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");


        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);//Rotar persoanje

        transform.Translate(0 , 0, y * Time.deltaTime * velocidadMovimiento);

        anim.SetFloat("VelX",x);

        anim.SetFloat("VelY",y);

    }
}
