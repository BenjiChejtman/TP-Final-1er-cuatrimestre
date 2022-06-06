﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public AudioClip GunSound;
    AudioSource FuenteAudio;

    public GameObject BalaInicio;
    public GameObject BalaPrefab;
    public float BalaVelocidad;

    void Start()
    {
        FuenteAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //1-Instanciar la BalaPrefab en las posiciones de BalaInicio
            GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position, BalaInicio.transform.rotation) as GameObject;

            //Obtener Rigidbody para agregar Fuerza. 
            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

            //Agregar la fuerza a la Bala
            rb.AddForce(transform.forward * BalaVelocidad);

            FuenteAudio.clip = GunSound;
            FuenteAudio.Play();

            //Debemos Destruir la bala
            Destroy(BalaTemporal, 5);


        }
    }
}