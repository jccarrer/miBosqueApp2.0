using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoPuzzle : MonoBehaviour
{
    public VideoPlayer VideoPlayer; // Drag & Drop the GameObject holding the VideoPlayer component
    // Start is called before the first frame update
    void Start()
    {
        VideoPlayer.loopPointReached += EndReached;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SalirJuego()
    {
        Application.Quit();
    }
    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene("submenuCuidandoElBosque");
    }
}