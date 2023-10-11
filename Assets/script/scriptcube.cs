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
    rend.material.color = new Color(0,0,1);
    rd.useGravity =true;  
}

}
