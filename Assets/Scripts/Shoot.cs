using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform spawnPoint;
    public float BulletSpeed;

    public GameObject Bullet;
    public GameObject User;
    public GameObject Pistol;

    GameObject BulletUsed;

    public AudioClip GunSound;
    AudioSource FuenteAudio;

    public Transform GunPosition;

    //GameObject[] bullets = new GameObject[5];
    //int i;

    void Start()
    {
        FuenteAudio = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        Bullet.transform.Translate();

        if (Input.GetKeyDown(KeyCode.E))
        {
            BulletUsed = Instantiate(Bullet);
            FuenteAudio.clip = GunSound;
            FuenteAudio.Play();
            Destroy(BulletUsed, 5);  
        }
        BulletUsed.transform.Translate(BulletSpeed, 0, 0);
    }
}