using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class ScriptPajaros : MonoBehaviour, IDropHandler
{
    public int valor = 5;
    public GameObject objeto1;
    public GameObject win;
    public int contador = 0;



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
        //var cont = false;
       // var cont2 = false;


        if (!item)
        {

            if ((eventData.pointerDrag.name == "Pajaro1") && (gameObject.name == "imgPajaro1Negro"))
            {
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform);
                Destroy(item);
                objeto1 = GameObject.Find("imgPajaro1Negro");
                objeto1.SetActive(false);
                //cont = true;
                contador++;
                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }

            if ((eventData.pointerDrag.name == "Pajaro2") && (gameObject.name == "imgPajaro2Negro"))
            {
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform);
                Destroy(item);
                objeto1 = GameObject.Find("imgPajaro2Negro");
                objeto1.SetActive(false);
                //cont2 = true;

                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }

           
            contador++;
            Debug.Log("ddddddddddddddddddddddddddddddddddd" + contador);


        }
        if (contador == 3)
        {
            Debug.Log("siiiiii entroooo");
            win.SetActive(true);
        }


    }



}
