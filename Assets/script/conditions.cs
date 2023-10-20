using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditions : MonoBehaviour

{
    public bool H2O;
    public bool R_OH;
    public Material mat;
    public float chaleur;

    // Start is called before the first frame update
    void Start()
    {

        if (H2O == true && chaleur < 0f)
        {
            mat.color = Color.blue;
        }
        else if (chaleur >= 0f && chaleur <= 1f)
        {
            mat.color = Color.white;
        }
        else
        {
            mat.color = Color.red;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
