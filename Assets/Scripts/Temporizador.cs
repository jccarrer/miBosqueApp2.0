using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Temporizador : MonoBehaviour
{
    public GameObject panel;
    public float timeLeft = 30.0f;
	public Text startText; // used for showing countdown from 3, 2, 1 
    

	void Update()
	{
		timeLeft -= Time.deltaTime;
		startText.text = (timeLeft).ToString("0");
		if (timeLeft < 0)
		{
            panel.SetActive(true);
        }
	}
}