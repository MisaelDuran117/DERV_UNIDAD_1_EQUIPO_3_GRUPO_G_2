using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager_UI : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    public void IniciarJuego(int index)
    {
        SceneManager.LoadScene(index);
    }
}
