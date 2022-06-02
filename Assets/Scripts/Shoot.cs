using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float BulletSpeed;

    public GameObject Bullet;
    public GameObject User;

    GameObject BulletUsed;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Bullet.transform.position = User.transform.position + new Vector3 (0.5f, 0, 0);
        //Bullet.transform.eulerAngles.y = User.transform.eulerAngles.y;

        if (Input.GetKeyDown(KeyCode.E))
        {
            BulletUsed = Instantiate(Bullet);
            Destroy(BulletUsed, 10);
        }

        BulletUsed.transform.position += new Vector3(BulletSpeed, 0, 0);
    }
}