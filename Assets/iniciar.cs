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
    
    public void PuzzleLvl2()
    {
        SceneManager.LoadScene("SegundoNivel");
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
    public void PuzzleLvl3()
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

}
