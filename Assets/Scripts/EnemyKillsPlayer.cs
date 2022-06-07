using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyKillsPlayer : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision colWithUser)
    {
        if (colWithUser.gameObject.name == "Player(User)")
        {
            Player.transform.position = new Vector3(0, 0.3f, 0);
            //InputField1.hide; 
            //InputField1.text = "Perdiste";
        }
    }
}
