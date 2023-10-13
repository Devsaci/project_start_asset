using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable : MonoBehaviour
{


    //Variable 
    public int age = 20;

    // Start is called before the first frame update
    void Start()
    {
        print("mon age20 est  : " + age);
        age =  50;
        print("mon age50 est  : " + age);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
