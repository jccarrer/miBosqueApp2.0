using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CargarSombra : MonoBehaviour
{
    public Image sombra;
    public string animal;
    private db objdb;
    private string monoBase, rataBase, osoBase, venadoBase;
    public Image i1, i2, i3, i4;

    public GameObject param;
    private Parametros prm;


    string[] sombras = {
        "Sprites/mono_capuchino-sombra",
        "Sprites/rata_espinosa-sombra",
        "Sprites/oso_perezoso-sombra",
        "Sprites/venado_cola_blanca-sombra"
    };



    // The output of the image
    public Image img;

    public void Start()
    {
        int index = 0;
        bool rep = true;
        Debug.Log("DENTRO DE " + name);
        param = GameObject.Find("Parametros");
        prm = param.GetComponent<Parametros>();
        sombras = prm.sombras_al();
        /*foreach (string i in sombras) {           
            Debug.Log("Sombras desde Parametros: " + i); 
        } */

        i1 = GameObject.Find("S1").GetComponent<Image>();
        i2 = GameObject.Find("S2").GetComponent<Image>();
        i3 = GameObject.Find("S3").GetComponent<Image>();
        i4 = GameObject.Find("S4").GetComponent<Image>();
        if (name == "S1")
        {
            sombra = GameObject.Find("S1").GetComponent<Image>();
        }
        if (name == "S2")
        {
            sombra = GameObject.Find("S2").GetComponent<Image>();
        }
        if (name == "S3")
        {
            sombra = GameObject.Find("S3").GetComponent<Image>();
        }
        if (name == "S4")
        {
            sombra = GameObject.Find("S4").GetComponent<Image>();
        }





        objdb = new db();








        while (rep == true)
        {
            rep = false;

            System.Random rand = new System.Random();
            index = rand.Next(sombras.Length);
            //string rd = rutas[index];
            string ruta = sombras[index];
            // Debug.Log("aleatorio SOMBRA "+name+": " + ruta);
            string[] dir = ruta.Split('/');
            string etiqueta = dir[dir.Length - 1];
            string[] et = etiqueta.Split('-');
            if (et[0].Contains(".png"))
            {
                string[] lab = et[0].Split('.');
                tag = lab[0];
                name = lab[0] + "_sombra";
                //Debug.Log("Contiene PNG");
                // Debug.Log("etiqueta final asignada: " + lab[0]);
                //Debug.Log("nombre final asignada: " + name);
            }
            else
            {
                tag = et[0];
                //Debug.Log("etiqueta asignada 1: " + et[0]);
            }
            sombra.sprite = Resources.Load<Sprite>(ruta);
            animal = ruta.Replace("sombra", "color");
            //Debug.Log("animal : "+ animal);

            //Debug.Log("SOMBRA DESPUES: " + sombra.sprite);
            if (name == "S1")
            {
                i1 = GameObject.Find("S1").GetComponent<Image>();
                if (i1.sprite == i2.sprite || i1.sprite == i3.sprite || i1.sprite == i4.sprite)
                {
                    rep = true;
                    //Debug.Log("SOMBRA REPETIDO :" +rep);  
                }
            }
            if (name == "S2")
            {
                i2 = GameObject.Find("S2").GetComponent<Image>();
                if (i2.sprite == i1.sprite || i2.sprite == i3.sprite || i2.sprite == i4.sprite)
                {
                    rep = true;
                    // Debug.Log("SOMBRA REPETIDO :" +rep);  
                }
            }
            if (name == "S3")
            {
                i3 = GameObject.Find("S3").GetComponent<Image>();
                if (i3.sprite == i1.sprite || i3.sprite == i2.sprite || i3.sprite == i4.sprite)
                {
                    rep = true;
                    // Debug.Log("SOMBRA REPETIDO :" +rep);  
                }
            }
            if (name == "S4")
            {
                i4 = GameObject.Find("S4").GetComponent<Image>();
                if (i4.sprite == i1.sprite || i4.sprite == i2.sprite || i4.sprite == i3.sprite)
                {
                    rep = true;
                    //Debug.Log("SOMBRA REPETIDO :" +rep);                
                }
            }
        }



    }

    public void Update()
    {

    }


}
