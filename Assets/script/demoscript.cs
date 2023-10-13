using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoscript : MonoBehaviour
{
    public Rigidbody rd;

    public string col = "Script 2";
    public int Vol;
    // Start is called before the first frame update
    void Start()
    {
        print("################script ########################");
        Debug.Log("message  : " + gameObject.name);
        gameObject.name = "MonCube";
        Debug.Log("message  : " + gameObject.name);


        print("###################Script######################");
        //gameObject.SetActive(true);
        //gameObject.SetActive(false);
        /* if (Input.GetMouseButtonDown(1))
         {
             rd.gameObject.SetActive(false);
         }*/

    }

    // Update is called once per frame
    void Update()
    {
        // print("script 1");
    }
}
