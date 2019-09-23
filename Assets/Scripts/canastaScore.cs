using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class canastaScore : MonoBehaviour
{
    // Start is called before the first frame update
    private Text scoreText;
    private Text faults;
    private int score=0;
    private int lose=0;
    
   
    void Awake()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        scoreText.text="0";

        faults = GameObject.Find("Faults").GetComponent<Text>();
        faults.text = "0";
    }


void OnTriggerEnter2D(Collider2D target){
        if(target.tag=="Bad"){
       // transform.position = new Vector2(0,100);
       target.gameObject.SetActive(false);
        lose++;
          if(lose==3){
        changeScene();
        
            }
            else if(score==0){
             score=0;
            scoreText.text = score.ToString();

                faults.text = lose.ToString();
            }
            else{
                 //StartCoroutine(RestartGame());
                 score=score-1;
                  scoreText.text = score.ToString();

                faults.text = lose.ToString();
            }
         }
           
           if(target.tag=="Fruits"){
           target.gameObject.SetActive(false);
           score++;
            if (score == 15)
            {
                SceneManager.LoadScene("ganaste");

            }
            else
            {
                //StartCoroutine(RestartGame());
                scoreText.text = score.ToString();
            }
             
        
           }
}

      /* IEnumerator RestartGame(){
                   yield return new WaitForSecondsRealtime(2f);
                   SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }*/

   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
     public void changeScene()
    {
    SceneManager.LoadScene("gameOver");
    }
}
