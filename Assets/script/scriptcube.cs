using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCube : MonoBehaviour
{

    // variables 
    public string coleur = "Rouge";
    public int intensité = 100;
    public bool connect = true;
    public float volt = 200.121f;
    // Start is called before the first frame update
    void Start()
    {
        print ("ma couleur est " + coleur);
        print ("mon intensité est :" + intensité);
        print ("mon voltage  est : " + volt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
