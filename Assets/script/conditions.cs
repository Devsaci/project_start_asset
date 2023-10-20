using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditions : MonoBehaviour

{
    public bool exemple;
    public Material mat;
    //public Color color = Color.cyan;
    public int chaleur;

    // Start is called before the first frame update
    void Start()
    {


        if (chaleur < 0)
        {
            mat.color = Color.blue;
        }
        else if (chaleur > 10)
        {
            mat.color = Color.red;
        }
       /* else
        {
            mat.color = Color.white;
        }*/



        /*
                if (exemple) 
                { 
                    mat.color = Color.red; 
                }
                else 
                { 
                    mat.color = Color.blue; 
                }*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
