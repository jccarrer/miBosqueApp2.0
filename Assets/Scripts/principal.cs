using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class principal : MonoBehaviour
{

    public GameObject panel;

   public void changeScene()
    {
    SceneManager.LoadScene("principal");
    }


    public void TogglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }

   
}
