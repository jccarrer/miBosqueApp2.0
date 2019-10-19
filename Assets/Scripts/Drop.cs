using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Drop : MonoBehaviour, IDropHandler {
   public int valor=5;
    public GameObject objeto1,objeto2;
    public GameObject panel;
    public GameObject estrella1;
    public GameObject estrella2;
    public GameObject estrella3,estrella4;
    //public int contador;
    public int contarEncendidos;
    public Inicio inicontador;
    //public AudioClip MusicClip;
    public AudioClip MusicClipMono;
    public AudioClip MusicClipOso;
    public AudioClip MusicClipRaton;
    public AudioClip MusicClipVenado;
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

    public void OnDrop(PointerEventData eventData )
    {
        //var cont = false;
        //var cont2 = false;
        int contador=0;

       
        objeto2 = GameObject.Find("estrella");
        Debug.Log("entre de nuevo");
        if (!item)
        {
            if ((eventData.pointerDrag.name == "Oso") && (gameObject.name == "imgOsoNegro"))
            {
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform);
                Destroy(item);
                objeto1 = GameObject.Find("imgOsoNegro");
                objeto1.SetActive(false);
                MusicSource.clip = MusicClipOso;
                MusicSource.Play();
                encenderEstrellas();
                //cont = true;
                estrella1.SetActive(true);
                contador++;
                //contar(contador);
                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name+"dddd" + contador);
            }else
            {
                MusicSource.clip = MusicClipError;
                MusicSource.Play();
            }

            if ((eventData.pointerDrag.name == "Raton") && (gameObject.name == "imgRatonNegro"))
            {
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform);
                Destroy(item);
                objeto1 = GameObject.Find("imgRatonNegro");
               
                objeto1.SetActive(false);
                //estrella2.SetActive(true);
                MusicSource.clip = MusicClipRaton;
                encenderEstrellas();
                MusicSource.Play();
               
                //objeto2.SetActive(false);
                // Debug.Log("Active Self: " + objeto2.activeSelf);
                //Debug.Log("Active in Hierarchy" + objeto2.activeInHierarchy);
                //cont2 = true;
                contador++;
                //contar(contador);
                // contador = contador + 1;
                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }

            if ((eventData.pointerDrag.name == "Mono") && (gameObject.name == "imgMonoNegro"))
            {
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform);
                Destroy(item);
                objeto1 = GameObject.Find("imgMonoNegro");
                objeto1.SetActive(false);
                MusicSource.clip = MusicClipMono;
                MusicSource.Play();
                encenderEstrellas();
                //estrella3.SetActive(true);
                // cont = true;
                contador++;
                //contar(contador);
                //contador = contador + 1;
                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }
            if ((eventData.pointerDrag.name == "Venado") && (gameObject.name == "imgVenadoNegro"))
            {
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform);
                Destroy(item);
                objeto1 = GameObject.Find("imgVenadoNegro");
                objeto1.SetActive(false);
                MusicSource.clip = MusicClipVenado;
                MusicSource.Play();
                encenderEstrellas();
                //estrella4.SetActive(true);
                // cont = true;
                contador++;
                //contar(contador);
                //contador = contador + 1;
                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }

            Debug.Log("aqui estoy cntando" + contador);
            if (contador == 3)
            {
                Debug.Log("siiiiii entroooo");
                //win.SetActive(true);
            }


        }
        Debug.Log("aqui estoy cntando9999999" + contador);
        if (contador == 3)
        {
            Debug.Log("siiiiii entroooo");
            //win.SetActive(true);
        }




    }

    public void encenderEstrellas()
    {
        contarEncendidos++;
        if (estrella1.activeSelf==false)
        {
            estrella1.SetActive(true);
          
        }
        else if(estrella2.activeSelf == false)
            {
                estrella2.SetActive(true);
            }else if(estrella3.activeSelf == false)
            {
                estrella3.SetActive(true);
             }else
                {
                 estrella4.SetActive(true);
                    panel.SetActive(true);
            //SceneManager.LoadScene(2);
        }
       // Debug.Log("va contando "+ contarEncendidos);
    }

    public void cambiarEscena(int numero)
    {
        SceneManager.LoadScene(numero);
    }




}
