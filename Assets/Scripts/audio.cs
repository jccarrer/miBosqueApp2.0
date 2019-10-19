using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class audio : MonoBehaviour
{
public Toggle toggle;
public AudioSource audi;

  
    void Start()
    {
      toggle = GameObject.Find("sound").GetComponent<Toggle>();
      audi= GameObject.Find("audio").GetComponent<AudioSource>();
        toggle.onValueChanged.AddListener((value) =>
            {
         MyListener(value);
           });//Do this in Start() for example
          
    }

public void MyListener(bool value)
       {
         if(value)
            {
            audi.Stop();
              }else {
                  //do the stuff when the toggle is off
                    audi.Play(); 
               }

        }
   

    // Update is called once per frame
    void Update()
    {
       
    }
}
