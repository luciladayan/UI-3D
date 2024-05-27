using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngresoScript : MonoBehaviour

{
    public InputField Input_IngresoPass;
    public string password = "manzana";

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void Checkpassword()

{
    if (Input_IngresoPass.text == password)
    { Debug.Log ("Access granted");
        }

        else
        {
            Debug.Log("Access Denied");
        }
}
}
