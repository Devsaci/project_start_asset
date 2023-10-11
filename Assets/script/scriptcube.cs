using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCube : MonoBehaviour
{

    // variables 
    public Color col;
    public Rigidbody rd;
    public Renderer rend;
  
    // Start is called before the first frame update
    void Start()
    {
       rend.material.color = col;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
