using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyFollowsUser : MonoBehaviour
{
    public GameObject Target;
    public GameObject FPSCamera;
    public Text NumeroKills;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, .03f);
    }

    void OnTriggerEnter(Collider colWithUser)
    {
        if (colWithUser.gameObject.name == "FPSController")
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (colWithUser.gameObject.name == "Cylinder(Clone)")
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }

    
}
