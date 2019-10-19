using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class irNivelDosperder : MonoBehaviour
{
    [System.Obsolete]
    void OnMouseDown()
    {
        //Debug.Log("click");
        //Application.LoadLevel("SampleScene");//paa cambiar de ecena revisar porque esta deprecado]\
        SceneManager.LoadScene("SegundoNivel");
        Time.timeScale = 1f;

    }
}
