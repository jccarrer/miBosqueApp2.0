using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class iniciar : MonoBehaviour {

	public void Iniciar ()
    {
        SceneManager.LoadScene("menuJuegos");
	}
    
	public void salir()
    {
        Application.Quit();
    }
    public void Juego1()
    {
        //SceneManager.LoadScene("menuJuego1"); juegoSiluetas
        SceneManager.LoadScene("submenuDescubreElHabitat");
    }

    public void Juego2()
    {
        //SceneManager.LoadScene("menuJuego1");
        SceneManager.LoadScene("submenuCuidandoElBosque");
    }

    public void Juego3()
    {
        SceneManager.LoadScene("submenuEncuentraLosPares");
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

    public void PuzzleLvl1()
    {
        SceneManager.LoadScene("JuegoRompecabeza");
    }
    
    public void PuzzleLvl2()
    {
        SceneManager.LoadScene("SegundoNivel");
    }
    public void PuzzleLvl3()
    {
        SceneManager.LoadScene("TercerNivelPuzzle");
    }

}
