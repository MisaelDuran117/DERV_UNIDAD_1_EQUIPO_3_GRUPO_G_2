using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_4_Rotacion : MonoBehaviour
{
    [SerializeField]
    float Angu = 90;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Codigo ejecitado una vez");
        

    }

   
    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.Q))
        {

            Quaternion origen = transform.rotation;
            Quaternion destino = Quaternion.Euler(new Vector3(0, Angu, 0));


            transform.transform.rotation = Quaternion.Slerp(origen, destino, 0.1f * Time.deltaTime);
            

            //Quaternion q = Quaternion.Euler(new Vector3(0, Angu, 0));
            //transform.transform.rotation = q;
        }

        if (Input.GetKey(KeyCode.E))
        {
            Quaternion origen = transform.rotation;
            Quaternion destino = Quaternion.Euler(new Vector3(0, -1* Angu, 0));

            transform.transform.rotation = Quaternion.Slerp(origen, destino, 0.1f * Time.deltaTime);

        }
        

    }
}
