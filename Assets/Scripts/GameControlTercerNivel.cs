using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlTercerNivel : MonoBehaviour
{

    private Vector2 initialPosition;
    public GameObject objectToDisable;
    public float delayTime = 2f;

    public GameObject panel;


    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;

        objectToDisable.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Pieza.locked && Pieza2.locked && Pieza3.locked && Pieza4.locked && Pieza5.locked && Pieza6.locked && Pieza7.locked && Pieza8.locked && Pieza9.locked && Pieza10.locked && Pieza11.locked && Pieza12.locked)
        {
            objectToDisable.SetActive(true);
            Invoke("DelayedAction", delayTime);
        }



    }

    void DelayedAction()
    {
        SceneManager.LoadScene("BienHecholvl3");
        /*panel.SetActive(true);
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
        Pieza12.locked = false; */
    }


}