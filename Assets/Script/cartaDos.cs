using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cartaDos : MonoBehaviour

{
    [SerializeField]
    private Scenecontrol2 controller = null;

    [SerializeField]
    private GameObject CartaDos = null;

    public void OnMouseDown()
    {
        if (CartaDos.activeSelf)
        {
            CartaDos.SetActive(false);
            controller.CardRevealed(this);
        }

    }

    private int _id;

    public int id
    {

        get { return _id; }
    }

    public void ChangeSprite(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;

    }

    public void Unreveal() //funcion voltear
    {
        CartaDos.SetActive(true);
    }

}