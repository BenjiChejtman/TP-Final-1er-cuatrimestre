using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{

    public AudioClip GunSound;
    AudioSource FuenteAudio;

    public GameObject BalaInicio;
    public GameObject BalaPrefab;
    public float BalaVelocidad;

    //public Text CantBalasAlcanzada;

    int i = 0;

    void Start()
    {
        FuenteAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position, BalaInicio.transform.rotation) as GameObject;
            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * BalaVelocidad);
            FuenteAudio.clip = GunSound;
            FuenteAudio.Play();
            Destroy(BalaTemporal, 0.4f);
        }
    }
}