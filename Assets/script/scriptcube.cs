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
    float val = Random.Range(0f,1f);
    rend.material.color = new Color(val,val,val);
    rd.useGravity =true;  
}

}
