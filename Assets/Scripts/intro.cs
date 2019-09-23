using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{
    public bool canMute;
    // Start is called before the first frame update
    public void Start()
    {
        canMute = true;
    }
    public void volver()
    {
        SceneManager.LoadScene("menuJuegos");
    }

    public void jugar()
    {
        SceneManager.LoadScene("juegoScene");
    }
    public void mute()
    {
       
        if (canMute)
        {
            AudioListener.pause = true;
            canMute = false;

        }
        else
        {
            AudioListener.pause = false;
            canMute = true;
        }
    }

}
