using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCube : MonoBehaviour
{

    // variables 
    public Rigidbody rd;
    public Renderer rend;
   
  
    // Start is called before the first frame update
    void Start()
    {
       rend.material.color = Color.red;
       rd.useGravity =true;
    }

    // Update is called once per frame
    void Update()
    {
     
    }

/// <summary>
/// OnMouseUp is called when the user has released the mouse button.
/// </summary>
private void OnMouseUp()
{
    
}

}
