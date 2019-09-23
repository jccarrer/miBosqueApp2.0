using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlSegundoNivel : MonoBehaviour
{

    private Vector2 initialPosition;
    public GameObject objectToDisable;
    public float delayTime = 3f;



    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;

        objectToDisable.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Pieza.locked && Pieza2.locked && Pieza3.locked && Pieza4.locked && Pieza5.locked && Pieza6.locked && Pieza7.locked && Pieza8.locked)
        {
            objectToDisable.SetActive(true);
            Invoke("DelayedAction", delayTime);
        }



    }

    void DelayedAction()
    {
        SceneManager.LoadScene("BienHecho");
    }


}