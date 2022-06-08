using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody gameObjectsRigidBody1 = Enemy1.AddComponent<Rigidbody>(); // Add the rigidbody.
        //Rigidbody gameObjectsRigidBody2 = Enemy2.AddComponent<Rigidbody>(); // Add the rigidbody.
        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObjectsRigidBody.mass = 5; // Set the GO's mass to 5 via the Rigidbody.
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cylinder(Clone)")
        {
            Destroy(Enemy1);
        }
        if (col.gameObject.name == "Cylinder(Clone)")
        {
            Destroy(Enemy2);
        }
        /*if (col.gameObject.name == "enemigo")
        {
            Destroy(col.gameObject);
        }
        Destroy(gameObject);*/
    }
}
