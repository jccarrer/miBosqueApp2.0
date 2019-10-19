using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class principal2 : MonoBehaviour
{
    public GameObject panel;

    public void changeScene()
    {
        SceneManager.LoadScene("menuJuegos");
    }


    public void TogglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }
}
