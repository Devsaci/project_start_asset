using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tableaux : MonoBehaviour
{
    public int[] tab1;


    // Start is called before the first frame update
    void Start()
    {
        tab1[3] = 1000;
        for (int i = 0; i < tab1.Length; i++) 
        {
            print(tab1[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
