using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CargarAnimales : MonoBehaviour
{

    public Image anim;
    private db objdb;
    public string[] aleatorias = { "", "", "", "", };
    public GameObject[] animales;

    string[] rutas = {
        "Sprites/mono_capuchino-color",
        "Sprites/rata_espinosa-color",
        "Sprites/oso_perezoso-color",
        "Sprites/venado_cola_blanca-color",
    };




    // The output of the image
    public Image img;

    // The source image
    string url = "https://clipground.com/images/monkey-baby-clipart-14.jpg";

    /*IEnumerator Start()
    {    
        if (name == "A1"){
            anim = GameObject.Find("A1").GetComponent<Image>();
        }
        if (name == "A2"){
            anim = GameObject.Find("A2").GetComponent<Image>();
        }
        if (name == "A3"){
            anim = GameObject.Find("A3").GetComponent<Image>();
        }
        if (name == "A4"){
            anim = GameObject.Find("A4").GetComponent<Image>();
        }
        Debug.Log("Nombre Soy: " + name);

        
        System.Random rand = new System.Random();
        int index = rand.Next(rutas.Length);
        string rd = rutas[index];
        string ruta = rutas[index];
        Debug.Log("aleatorio "+name+": " + ruta);
        string[] dir = ruta.Split('/');        
        string etiqueta = dir[dir.Length-1];        
        string[] et = etiqueta.Split('-'); 
        if(et[0].Contains(".png")){
            string[] lab = et[0].Split('.'); 
            tag = lab[0];
            name = lab[0];
            //Debug.Log("Contiene PNG");
            Debug.Log("etiqueta final asignada: " + lab[0]);
        }else{
            tag = et[0];
            Debug.Log("etiqueta asignada 1: " + et[0]);
        }
        anim.sprite = Resources.Load<Sprite>(ruta); //"Sprites/oso perezoso_1"

        WWW www = new WWW((rutas[index]));        
             
        yield return www;
        //img.sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0), 1);
       
    }*/

    public void Start()
    {






        System.Random rand = new System.Random();
        //aleatorias[] = new string[]{};
        int azar = 0;
        int x = 0;
        string r_azar = "";
        bool repetido = false;
        for (int i = 0; i < 4; i++)
        {
            azar = rand.Next(rutas.Length);
            //Debug.Log("NUEVO AZAR : "+azar);
            r_azar = rutas[azar];
            x = 0;
            repetido = false;
            while (i > 0 && x < i)
            {
                if (r_azar == aleatorias[x])
                {
                    //Debug.Log("REPETIDO : "+aleatorias[i]);
                    repetido = true;
                    x = i;
                }
                else
                {

                }
                x++;
            }
            if (repetido)
            {
                aleatorias[i] = "";
                i--;
            }
            else
            {
                aleatorias[i] = r_azar;
            }

            //Debug.Log("NUEVO ALEAT : "+aleatorias[i]);
        }
        for (int i = 0; i < 4; i++)
        {
            Debug.Log("ALEAT FINAL :" + aleatorias[i]);
        }
    }

    public void Update()
    {

    }





}
