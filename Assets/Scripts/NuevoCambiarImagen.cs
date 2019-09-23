using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class NuevoCambiarImagen : MonoBehaviour
{

    public Image anim;
    public Image i1, i2, i3, i4;
    private db objdb;
    public GameObject param;
    private Parametros prm;
    private string monoBase, rataBase, osoBase, venadoBase;
    public CargarAnimales charge;
    //public GameObject comp1,comp2,comp3;
    public string miruta;




    string[] animales = {
        "Sprites/mono_capuchino-color",
        "Sprites/rata_espinosa-color",
        "Sprites/oso_perezoso-color",
        "Sprites/venado_cola_blanca-color"
    };



    // The output of the image
    public Image img;

    // The source image
    string url = "https://clipground.com/images/monkey-baby-clipart-14.jpg";

    public void Start()
    {
        Debug.Log("DENTRO DE " + name);
        param = GameObject.Find("Parametros");
        prm = param.GetComponent<Parametros>();
        animales = prm.aleatorios();
        /*foreach (string i in animales) {           
            Debug.Log("Animales desde Parametros: " + i); 
        }*/



        int index = 0;
        bool rep = true;

        i1 = GameObject.Find("A1").GetComponent<Image>();
        i2 = GameObject.Find("A2").GetComponent<Image>();
        i3 = GameObject.Find("A3").GetComponent<Image>();
        i4 = GameObject.Find("A4").GetComponent<Image>();
        if (name == "A1")
        {
            anim = GameObject.Find("A1").GetComponent<Image>();
        }
        if (name == "A2")
        {
            anim = GameObject.Find("A2").GetComponent<Image>();
        }
        if (name == "A3")
        {
            anim = GameObject.Find("A3").GetComponent<Image>();
        }
        if (name == "A4")
        {
            anim = GameObject.Find("A4").GetComponent<Image>();
        }


        objdb = new db();
        // objdb = anim.AddComponent<db>();






        while (rep == true)
        {
            rep = false;
            System.Random rand = new System.Random();
            index = rand.Next(animales.Length);
            //string rd = rutas[index];
            string ruta = animales[index];
            //Debug.Log("aleatorio "+name+": " + ruta);
            string[] dir = ruta.Split('/');
            string etiqueta = dir[dir.Length - 1];
            string[] et = etiqueta.Split('-');
            if (et[0].Contains(".png"))
            {
                string[] lab = et[0].Split('.');
                tag = lab[0];
                name = lab[0];
                //Debug.Log("Contiene PNG");
                //  Debug.Log("etiqueta final asignada: " + lab[0]);
            }
            else
            {
                tag = et[0];
                //Debug.Log("etiqueta asignada 1: " + et[0]);
            }
            anim.sprite = Resources.Load<Sprite>(ruta); //"Sprites/oso perezoso_1"

            //Debug.Log("ANIMAL DESPUES: " + anim.sprite);
            if (name == "A1")
            {
                i1 = GameObject.Find("A1").GetComponent<Image>();
                if (i1.sprite == i2.sprite || i1.sprite == i3.sprite || i1.sprite == i4.sprite)
                {
                    rep = true;
                    //Debug.Log("ANIMAL REPETIDO :" +rep);  
                }
            }
            if (name == "A2")
            {
                i2 = GameObject.Find("A2").GetComponent<Image>();
                if (i2.sprite == i1.sprite || i2.sprite == i3.sprite || i2.sprite == i4.sprite)
                {
                    rep = true;
                    //Debug.Log("ANIMAL REPETIDO :" +rep);  
                }
            }
            if (name == "A3")
            {
                i3 = GameObject.Find("A3").GetComponent<Image>();
                if (i3.sprite == i1.sprite || i3.sprite == i2.sprite || i3.sprite == i4.sprite)
                {
                    rep = true;
                    // Debug.Log("ANIMAL REPETIDO :" +rep);  
                }
            }
            if (name == "A4")
            {
                i4 = GameObject.Find("A4").GetComponent<Image>();
                if (i4.sprite == i1.sprite || i4.sprite == i2.sprite || i4.sprite == i3.sprite)
                {
                    rep = true;
                    // Debug.Log("ANIMAL REPETIDO :" +rep);                
                }
            }

            /*Debug.Log("ANIMAL estado :" +rep);  
            Debug.Log("ANIMAL 1 : " + i1.sprite);
            Debug.Log("ANIMAL 2 : " + i2.sprite);
            Debug.Log("ANIMAL 3 : " + i3.sprite);
            Debug.Log("ANIMAL 4 : " + i4.sprite);*/

        }


    }



    public void Update()
    {


    }


}
