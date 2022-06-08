using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene("SampleScene");
        }

        if (colWithUser.gameObject.name == "Cylinder(Clone)")
        {
            Destroy(gameObject);
            Debug.Log("Funciona");
        }
    }

    
}
