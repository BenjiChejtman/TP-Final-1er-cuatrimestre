﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyFollowsUser : MonoBehaviour
{
    public GameObject Target;
    public GameObject FPSCamera;
    public GameObject Cube;
    public Text Perdiste;
    public Text TextKills;
    int Kills;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, .1f);
    }

    void OnTriggerEnter(Collider colWithUser)
    {
        
        if (colWithUser.gameObject.name == "Cylinder(Clone)")
        {
            transform.position = new Vector3(0, 2, 0);
            
            Kills++;
            TextKills.text = "Kills: "+Kills;
            while(i < 3)
            {
                Instantiate(Cube);
                i++;
            }
            if(Kills == 10)
            {
                SceneManager.LoadScene("Ganaste");
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "FPSController")
        {
            
            SceneManager.LoadScene("Perdiste");  

        }

    }



}
