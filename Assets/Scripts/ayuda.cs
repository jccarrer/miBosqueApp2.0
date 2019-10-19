using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ayuda : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TogglePanel ( GameObject Panel)
    {
        Panel.SetActive(!Panel.activeSelf);
    }
}
