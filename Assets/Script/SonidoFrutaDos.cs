using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoFrutaDos : MonoBehaviour
{

    // Start is called before the first frame update
    public AudioClip fruta;
    public AudioSource sonidofruta;

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void nombrar_fruta(string s_fruta)
    {
        fruta = Resources.Load<AudioClip>("Sounds/paty_" + s_fruta + "-sonido");
        sonidofruta.clip = fruta;
        sonidofruta.Play();
    }
}