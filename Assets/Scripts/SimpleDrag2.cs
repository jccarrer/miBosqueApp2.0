using UnityEngine.EventSystems;
using UnityEngine;

// This script allows you to drag this GameObject using any finger, as long it has a collider
public class SimpleDrag2 : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, 
                         IPointerExitHandler, IDragHandler, IBeginDragHandler, IEndDragHandler {

    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;



    //Se ejecuta repetidamente mientras se esté arrastrando
    public void OnDrag(PointerEventData eventData)
{
        this.transform.position = eventData.position;
        Debug.Log(eventData.pointerDrag.name + "Está siendo arrastrado");
        Debug.Log(eventData.pointerDrag.tag + " Este es el tag");
    }

    //Se ejecuta cuando ha empezado a arrastrarse, antes del OnDrag
    public void OnBeginDrag(PointerEventData eventData)
{
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        //startParent = transform.parent;
        //Debug.Log("Va a ser arrastrado");
    }

//Se ejecuta cuando se ha soltado, antes del OnDrop
public void OnEndDrag(PointerEventData eventData)
{
        itemBeingDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent == startParent)
        {
            transform.position = startPosition;
        }
        //Debug.Log("Va a ser soltado");
}


//Se ejecuta al finalizar la pulsación completa (levantar el dedo o ratón)
public void OnPointerClick(PointerEventData eventData)
{
    //Debug.Log("Ha sido pulsado");
}

//Se ejecuta cuando el punto del ratón pasa por encima
public void OnPointerEnter(PointerEventData eventData)
{
    Debug.Log("El ratón está encima");
}

//Se ejecuta cuando el puntero, después de haber pasado por encima, sale de su collider
public void OnPointerExit(PointerEventData eventData)
{
    Debug.Log("El ratón ya NO está encima");
}

}