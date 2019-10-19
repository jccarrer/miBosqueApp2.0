using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    //public void cambiar()
    //{
        //Debug.Log("ddddd");
        //SceneManager.LoadScene("introBosque");
    //}
    
       public void volverMenu()
    {
        //Debug.Log("ddddd");
        //SceneManager.LoadScene("menuJuego1");
        SceneManager.LoadScene("menuJuegos");

    }
}
