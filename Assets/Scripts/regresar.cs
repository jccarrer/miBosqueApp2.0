using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class regresar : MonoBehaviour
{
    // Start is called before the first frame update
    //public void volver()
    //{
    //    SceneManager.LoadScene("menuJuegos");
    //}
    
       public void volverMenu()
    {
        //Debug.Log("ddddd");
        SceneManager.LoadScene("menuJuego1");
    }

    public void jugar()
    {
        SceneManager.LoadScene("juegoScene");
    }

    public void salir()
    {
        //Debug.Log("ddddd");
        Application.Quit();
    }
}
