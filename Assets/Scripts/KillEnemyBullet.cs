using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    { 
        if (col.gameObject.name == "EnemyCapsule(Clone)")
        {
            Destroy(col.gameObject);
        }
        Destroy(gameObject);
    }
}

/*if (col.gameObject.name == "Cylinder(Clone)")
       {
           Destroy(Enemy1);
       }
       if (col.gameObject.name == "Cylinder(Clone)")
       {
           Destroy(Enemy2);
       }*/
