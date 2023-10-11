using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCube : MonoBehaviour
{

    // variables 
    public Rigidbody rd;
    public Renderer rend
    float speed = 3;
   
  
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey(KeyCode.UpArrow))
     {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
     }
     if(Input.GetKey(KeyCode.DownArrow))
     {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
     }
      if(Input.GetKey(KeyCode.LeftArrow))
     {
        transform.Translate(Vector3.Left * Time.deltaTime * speed);
     }
      if(Input.GetKey(KeyCode.UpArrow))
     {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
     }
    }

/// <summary>
/// OnMouseUp is called when the user has released the mouse button.
/// </summary>
private void OnMouseUp()
{
    //float val = Random.Range(0f,1f);
    rend.material.color = new Color(
        Random.Range(0f,1f),
        Random.Range(0f,1f),
        Random.Range(0f,1f)
        );
    rd.useGravity =true;  
}

}
