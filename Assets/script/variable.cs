using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable : MonoBehaviour
{


    //Variable 
    public int age = 20;
    public string phrase = "52";
    public Color color;
    public Material mat;

    // Start is called before the first frame update
    void Start()
    {
     mat.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
