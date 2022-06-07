using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowsUser : MonoBehaviour
{
    public GameObject Target;
    public GameObject FPSCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, .03f);
    }

    void OnCollisionEnter(Collision colWithUser)
    {
        if (colWithUser.gameObject.name == "FPSController")
        {
            Target.transform.position = new Vector3(20, 0.3f, 0);
            FPSCamera.transform.position = new Vector3(20, 0.3f, 0);
        }
    }
}
