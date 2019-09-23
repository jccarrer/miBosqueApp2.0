using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using System.Threading;

public class DropPajaro : MonoBehaviour, IDropHandler
{
    public int valor = 5;
    public GameObject objeto1;
    public GameObject win;
    public GameObject panel;
    public GameObject estrella1;
    public GameObject estrella2;
    public GameObject estrella3, estrella4;
    public int contador = 0;
    public int contarEncendidos;
   // public AudioClip MusicClip;
    public AudioClip MusicClipGolondrina;
    public AudioClip MusicClipPapagayo;
    public AudioClip MusicClipGarceta;
    public AudioClip MusicClipUrraca;
    public AudioClip MusicClipError;
    public AudioSource MusicSource;


    public GameObject item
    {
        get
        {
            if (transform.childCount > 0)
            {
                Debug.Log("sdsdsdsd");
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            if ((eventData.pointerDrag.name == "Pajaro1") && (gameObject.name == "imgPajaro1Negro"))
            {
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform);
                Destroy(item);
                objeto1 = GameObject.Find("imgPajaro1Negro");
                objeto1.SetActive(false);
                //cont = true;
                encenderEstrellas();
                MusicSource.clip = MusicClipUrraca;
                MusicSource.Play();
                contador++;
                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }else
            {
                MusicSource.clip = MusicClipError;
                MusicSource.Play();
            }

            if ((eventData.pointerDrag.name == "Pajaro2") && (gameObject.name == "imgPajaro2Negro"))
            {
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform);
                Destroy(item);
                objeto1 = GameObject.Find("imgPajaro2Negro");
                objeto1.SetActive(false);
                encenderEstrellas();
                MusicSource.clip = MusicClipPapagayo;
                MusicSource.Play();
                //cont2 = true;

                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }


            if ((eventData.pointerDrag.name == "Pajaro3") && (gameObject.name == "imgPajaro3Negro"))
            {
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform);
                Destroy(item);
                objeto1 = GameObject.Find("imgPajaro3Negro");
                objeto1.SetActive(false);
                encenderEstrellas();
                MusicSource.clip = MusicClipGarceta;
                MusicSource.Play();
            }
                //cont2 = true;
           

            if ((eventData.pointerDrag.name == "Pajaro4") && (gameObject.name == "imgPajaro4Negro"))
            {
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform);
                Destroy(item);
                objeto1 = GameObject.Find("imgPajaro4Negro");
                objeto1.SetActive(false);
                encenderEstrellas();
                MusicSource.clip = MusicClipGolondrina;
                MusicSource.Play();
                //cont2 = true;
                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }
            contador++;
            Debug.Log("ddddddddddddddddddddddddddddddddddd" + contador);


        }

    }

    public void encenderEstrellas()
    {
        contarEncendidos++;
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

            Invoke("HideShowGameobject", 3);
            //SceneManager.LoadScene(2);
        }
        // Debug.Log("va contando "+ contarEncendidos);
    }


    void HideShowGameobject()
    {
        if (panel.active)
            panel.SetActive(false);
        else
            panel.SetActive(true); ;
    }




}

