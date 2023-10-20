using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boucles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /* for(int i = 0; i < 10; i++) 
         {
             print(message: "la valeur de i est :  " + i);
         }*/
        int i = 0;
        while (i < 10)
        { 
            i = i + 1; 
        };
        print("i vaut : " + i);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
