using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class juego : MonoBehaviour
{
    public void changeScene(string nameScene)
    {
    SceneManager.LoadScene("juego");
    }
    
    public void changeSceneTwo(string nameScene)
    {
    SceneManager.LoadScene("juego2");
    }

    public void menu()
    {
        SceneManager.LoadScene("menuJuegos");
    }
}
