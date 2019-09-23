using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NuevoDrop : MonoBehaviour, IDropHandler
{

    public GameObject objeto1;
    public GameObject panel;
    public GameObject estrella1;
    public GameObject estrella2;
    public GameObject estrella3;
    public GameObject estrella4;
    public int contarEncendidos;
    public Inicio inicontador;
    public AudioClip MusicClipError;
    public AudioClip audio;
    public AudioSource MusicSource;
    public Image anim;
    public Image img;


    public GameObject item
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        //var cont = false;
        //var cont2 = false;
        int contador = 0;


        if (!item)
        {
            if ((eventData.pointerDrag.tag == gameObject.tag))
            {
                Debug.Log("COINCIDENCIA entre " + eventData.pointerDrag.name + " y " + gameObject.name);
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform);
                string imag = eventData.pointerDrag.tag;
                string sonido = eventData.pointerDrag.tag;
                Destroy(item);
                objeto1 = GameObject.Find(eventData.pointerDrag.name);
                anim = GameObject.Find(gameObject.name).GetComponent<Image>();
                anim.sprite = Resources.Load<Sprite>("Sprites/" + imag + "-color");
                objeto1.SetActive(false);
                audio = Resources.Load<AudioClip>("Sounds/" + sonido + "-sonido");
                MusicSource.clip = audio;
                MusicSource.Play();
                encenderEstrellas();
            }
            else
            {
                MusicSource.clip = MusicClipError;
                MusicSource.Play();
            }
        }
    }

    public void encenderEstrellas()
    {
        if (estrella1.activeSelf == false)
        {
            estrella1.SetActive(true);
        }
        else if (estrella2.activeSelf == false)
        {
            estrella2.SetActive(true);
        }
        else if (estrella3.activeSelf == false)
        {
            estrella3.SetActive(true);
        }
        else
        {
            estrella4.SetActive(true);
            Debug.Log("Salto directo");
            Invoke("HideShowGameobject", 3);
            //SceneManager.LoadScene(2);
        }
    }

    public void cambiarEscena(int numero)
    {
        SceneManager.LoadScene(numero);
    }

    void HideShowGameobject()
    {
        if (panel.active)
            panel.SetActive(false);
        else
            panel.SetActive(true); ;
    }


}
