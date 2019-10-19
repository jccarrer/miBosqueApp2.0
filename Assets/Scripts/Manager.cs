using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject saman, bototillo, mango, tamarindo, paloSanto,cactus,arbol,arbolPlano,cactusPlano, samanPlano, bototilloPlano, mangoPlano, tamarindoPlano, paloSantoPlano, samanEncima, bototilloEncima, mangoEncima, tamarindoEncima, paloSantoEncima, hoja1, hoja2, hoja3,hoja4,hoja5,ganado;

    Vector2 samanInitialPos, bototilloInitialPos, mangoInitialPos, tamarindoInitialPos, paloSantoInitialPos, cactusInitialPos, arbolInitialPos;
   

    public AudioSource source;
    public AudioClip audioBototillo;
    public AudioClip audiopaloSanto;
    public AudioClip audioMango;
    public AudioClip audioTamarindo;
    public AudioClip audioSaman;
    public AudioClip fondo;

    int cont = 0;




    public AudioClip incorrect;

    bool samancorrect, bototillocoreect, mangocorrect, tamarindocorrect, arbolcorrect,cactuscorrect, palocorrect =false;

    private void Start()
    {

        samanInitialPos = saman.transform.position;
        bototilloInitialPos = bototillo.transform.position;
        mangoInitialPos = mango.transform.position;
        tamarindoInitialPos = tamarindo.transform.position;
        paloSantoInitialPos = paloSanto.transform.position;
        arbolInitialPos = arbol.transform.position;
        cactusInitialPos = cactus.transform.position;
        samanEncima.SetActive(false);
        bototilloEncima.SetActive(false);
        paloSantoEncima.SetActive(false);
        mangoEncima.SetActive(false);
        tamarindoEncima.SetActive(false);
        hoja1.SetActive(false);
        hoja2.SetActive(false);
        hoja3.SetActive(false);
        hoja4.SetActive(false);
        hoja5.SetActive(false);
       
    }
    public void DragSaman()
    {
        saman.transform.position = Input.mousePosition;

    }

    public void DragBototillo()
    {
        bototillo.transform.position = Input.mousePosition;

    }

    public void DragMango()
    {
        mango.transform.position = Input.mousePosition;

    }

    public void DragTamarindo()
    {
        tamarindo.transform.position = Input.mousePosition;

    }

    public void DragPaloSanto()
    {
        paloSanto.transform.position = Input.mousePosition;

    }
    public void DragCactus()
    {
        cactus.transform.position = Input.mousePosition;

    }

    public void DragArbol()
    {
        arbol.transform.position = Input.mousePosition;

    }



    //DROP

    public void DropSaman()
    {
        float Distance = Vector3.Distance(saman.transform.position, samanPlano.transform.position);
        if (Distance < 100)
        {
            saman.transform.position = samanPlano.transform.position;
            float myscale = 3f;
            source.clip = audioSaman;
            source.Play();
            saman.transform.localScale = transform.localScale = new Vector4(myscale, myscale, myscale);

          
            samancorrect = true;
            saman.SetActive(false);
            samanEncima.SetActive(true);
            hoja1.SetActive(true);


        }
        else
        {
            saman.transform.position = samanInitialPos;
            source.clip = incorrect;
            source.Play();
        }


    }



    public void DropBototillo()
    {
        float Distance = Vector3.Distance(bototillo.transform.position, bototilloPlano.transform.position);
        if (Distance < 100)
        {
            bototillo.transform.position = bototilloPlano.transform.position;
            float myscale1 = 2.31f;

            source.clip = audioBototillo;
            source.Play();
            bototillo.transform.localScale = transform.localScale = new Vector4(myscale1, myscale1, myscale1);
            bototillocoreect = true;
            bototillo.SetActive(false);
            bototilloEncima.SetActive(true);
            hoja2.SetActive(true);
            cont++;
        }
        else
        {
            bototillo.transform.position = bototilloInitialPos;
            source.clip = incorrect;
            source.Play();

          


        }


    }

    public void DropMango()
    {
        float Distance = Vector3.Distance(mango.transform.position, mangoPlano.transform.position);
        if (Distance < 100)
        {
            mango.transform.position = mangoPlano.transform.position;
            float myscale2 = 2.5f;
            source.clip = audioMango;
            source.Play();
            mango.transform.localScale = transform.localScale = new Vector4(myscale2, myscale2, myscale2);
            mangocorrect = true;

            mango.SetActive(false);
            mangoEncima.SetActive(true);
            hoja3.SetActive(true);
            cont++;
        }
        else
        {
            mango.transform.position = mangoInitialPos;
            source.clip = incorrect;
            source.Play();



        }


    }

    public void DropTamarindo()
    {
        float Distance = Vector3.Distance(tamarindo.transform.position, tamarindoPlano.transform.position);
        if (Distance < 100)
        {
            tamarindo.transform.position = tamarindoPlano.transform.position;
            float myscale3 = 1.88f;
            source.clip = audioTamarindo;
            source.Play();
            tamarindo.transform.localScale = transform.localScale = new Vector4(myscale3, myscale3, myscale3);
            tamarindocorrect = true;

            tamarindo.SetActive(false);
            tamarindoEncima.SetActive(true);
            hoja4.SetActive(true);
            cont++;
        }
        else
        {
            tamarindo.transform.position = tamarindoInitialPos;
            source.clip = incorrect;
            source.Play();

        }


    }

    public void DropPaloSanto()
    {
        float Distance = Vector3.Distance(paloSanto.transform.position, paloSantoPlano.transform.position);
        if (Distance < 100)
        {
            paloSanto.transform.position = paloSantoPlano.transform.position;
            float myscale4 = 2.5f;
            source.clip = audiopaloSanto;
            source.Play();
            paloSanto.transform.localScale = transform.localScale = new Vector4(myscale4, myscale4, myscale4);
            palocorrect = true;

            paloSanto.SetActive(false);
            paloSantoEncima.SetActive(true);
            hoja5.SetActive(true);
            cont++;

        }
        else
        {
            paloSanto.transform.position = paloSantoInitialPos;
            source.clip = incorrect;
            source.Play();

        }


    }
    
    public void DropArbol()
    {
        float Distance = Vector3.Distance(arbol.transform.position, arbolPlano.transform.position);

        if (Distance < 20)
        {
            arbol.transform.position = arbolPlano.transform.position;



        }
        else
        {
            arbol.transform.position = arbolInitialPos;
            source.clip = incorrect;
            source.Play();


        }
    }

        public void DropCactus()
        {
            float Distance = Vector3.Distance(cactus.transform.position, cactusPlano.transform.position);

            if (Distance < 20)
            {
                cactus.transform.position = cactusPlano.transform.position;



            }
            else
            {
                cactus.transform.position = cactusInitialPos;
                source.clip = incorrect;
                source.Play();


            }




        }


        void Update()
    {
        if(samancorrect && bototillocoreect && tamarindocorrect && mangocorrect && palocorrect)
        {
            Debug.Log("You Win!");
            SceneManager.LoadScene("ganador");

        }

    }


}

