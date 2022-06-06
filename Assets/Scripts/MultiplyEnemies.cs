using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplyEnemies : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    int counter = 0;

    Vector3 posicionInicial1;
    Vector3 posicionInicial2;
    Vector3 myVector31;
    Vector3 myVector32;

    int i1 = 0;
    int i2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        posicionInicial1.x = 1;
        posicionInicial1.y = 2;
        posicionInicial2.x = 3;
        posicionInicial2.y = 2;
        Enemy1.transform.position = posicionInicial1;
        Enemy2.transform.position = posicionInicial2;
    }

    // Update is called once per frame
    void Update()
    {
            while(counter < 5)
            {
                Instantiate(Enemy1);
                Instantiate(Enemy2);
                counter++;
                myVector31.x = i1;
                
                myVector32.x = i2;
                ;
            Enemy1.transform.position = posicionInicial1 + myVector31;
                Enemy2.transform.position = posicionInicial2 + myVector32;
                i1 +=3;
                i2 += 3;
            }   
    }
}
