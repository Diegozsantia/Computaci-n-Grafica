﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaDelPersonaje : MonoBehaviour
{

    public float VelocidadPersonajeCaminando = 50.0f;
    public float VelocidadPersonajeRotacion = 50.0f;
    private Animator anim;
    public float x, y;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * VelocidadPersonajeRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * VelocidadPersonajeCaminando);

        anim.SetFloat("velX", x);
        anim.SetFloat("velY", y);
    }
}