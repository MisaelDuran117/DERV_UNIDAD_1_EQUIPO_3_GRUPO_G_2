using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_2_GetKeys_Movement : MonoBehaviour
{
    [SerializeField]
    float velocidad = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Codigo ejecitado una vez");
        

    }

   
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(
              transform.forward * velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(
                transform.forward * velocidad *Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(
                transform.forward *-1* velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(
                transform.forward * velocidad * Time.deltaTime);
        }

    }
}
