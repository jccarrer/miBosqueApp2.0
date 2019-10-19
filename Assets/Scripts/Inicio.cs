﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour {
    //public GameObject objeto1;
    // Use this for initialization
    public GameObject panel;

    void Start () {
        //Estrella.SetActive(false);
        //objeto1 = GameObject.Find("estrella");
        //objeto1.GetComponent<Renderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void inicioDelJuego()
    {
        SceneManager.LoadScene("inicioAnimadov1");
    }

    public void medallaSiluetas()
    {
        SceneManager.LoadScene("medallaSiluetas");
    }
    
        
    public void medallaRompecabeza()
    {
        SceneManager.LoadScene("medallaRompecabeza");
        Pieza.locked = false;
        Pieza2.locked = false;
        Pieza3.locked = false;
        Pieza4.locked = false;
        Pieza5.locked = false;
        Pieza6.locked = false;
        Pieza7.locked = false;
        Pieza8.locked = false;
        Pieza9.locked = false;
        Pieza10.locked = false;
        Pieza11.locked = false;
        Pieza12.locked = false;
    }

    public void medallaPares()
    {
        SceneManager.LoadScene("medallaPares");
    }


    public void cambiar()
    {
        //Debug.Log("ddddd");
        SceneManager.LoadScene("menuJuegos");
    }
    public void DescubreElHabitat_Aves()
    {
        SceneManager.LoadScene("juego1_aves");
    }
    public void DescubreElHabitat_Mamiferos()
    {
        SceneManager.LoadScene("NewCombinados");
    }
    public void DescubreElHabitat_Arboles()
    {
        SceneManager.LoadScene("juego1_arboles");
    }


    public void volverMenu()
    {
        //Debug.Log("ddddd");
        SceneManager.LoadScene("menuJuegos");
    }

    public void cambiarPajaros(int escenaMamiferos)
    {
        //Debug.Log("ddddd");
        SceneManager.LoadScene(escenaMamiferos);
    }

    public void cambiarMamiferos(int escenaPajaros)
    {
        //Debug.Log("ddddd");
        SceneManager.LoadScene(escenaPajaros);
    }


    public void PuzzleNivel1()
    {
        SceneManager.LoadScene("JuegoRompecabeza");
        Pieza.locked = false;
        Pieza2.locked = false;
        Pieza3.locked = false;
        Pieza4.locked = false;
        Pieza5.locked = false;
        Pieza6.locked = false;
        Pieza7.locked = false;
        Pieza8.locked = false;
        Pieza9.locked = false;
        Pieza10.locked = false;
        Pieza11.locked = false;
        Pieza12.locked = false;

    }

    public void PuzzleNivel2()
    {
        SceneManager.LoadScene("SegundoNivelPuzzle");
        Pieza.locked = false;
        Pieza2.locked = false;
        Pieza3.locked = false;
        Pieza4.locked = false;
        Pieza5.locked = false;
        Pieza6.locked = false;
        Pieza7.locked = false;
        Pieza8.locked = false;
       
    }
    public void PuzzleNivel3()
    {
        SceneManager.LoadScene("TercerNivelPuzzle");
        Pieza.locked = false;
        Pieza2.locked = false;
        Pieza3.locked = false;
        Pieza4.locked = false;
        Pieza5.locked = false;
        Pieza6.locked = false;
        Pieza7.locked = false;
        Pieza8.locked = false;
        Pieza9.locked = false;
        Pieza10.locked = false;
        Pieza11.locked = false;
        Pieza12.locked = false;
    }


    public void submenuPares()
    {
        SceneManager.LoadScene("submenuEncuentraLosPares");
    }

    public void submenuCuidandoElBosque()
    {
        SceneManager.LoadScene("submenuCuidandoElBosque");
    }

    public void ParesNivel1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ParesNivel2()
    {
        SceneManager.LoadScene("SegundoNivel");
    }
    public void ParesNivel3()
    {
        SceneManager.LoadScene("TercerNivel");
    }

    public void submenuDescubreElHabitat()
    {
        SceneManager.LoadScene("submenuDescubreElHabitat");
        Pieza.locked = false;
        Pieza2.locked = false;
        Pieza3.locked = false;
        Pieza4.locked = false;
        Pieza5.locked = false;
        Pieza6.locked = false;
        Pieza7.locked = false;
        Pieza8.locked = false;
        Pieza9.locked = false;
        Pieza10.locked = false;
        Pieza11.locked = false;
        Pieza12.locked = false;
    }
    
    public void Juego3()
    {
        SceneManager.LoadScene("juegoScene");
    }

    public void ayudaSilueta()
    {
        SceneManager.LoadScene("InfoJuegoSilueta");
    }


    public void ayudaPanelOn()
    {
        panel.SetActive(true);

    }

    public void ayudaPanelOff()
    {
        panel.SetActive(false);
    }

    public void VideoSilueta()
    {
        SceneManager.LoadScene("VideoSilueta");
    }
    public void VideoPuzzle()
    {
        SceneManager.LoadScene("VideoPuzzle");
    }
    public void VideoPares()
    {
        SceneManager.LoadScene("VideoPares");
    }
    public void salir()
    {
        //Debug.Log("ddddd");
        Application.Quit();
    }


}
