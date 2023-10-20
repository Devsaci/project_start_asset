using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditions : MonoBehaviour

{
    public bool exemple;
    public Material mat;

    // Start is called before the first frame update
    void Start()
    {
        if (exemple == true) { mat.color = Color.red; };
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
