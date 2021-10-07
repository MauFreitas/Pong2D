using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class pontuacao : MonoBehaviour

{
    public Text Score;
    public int score1;
    public int score2;
    public GameObject bola;
    public GameObject p1win;
    public GameObject p2win;



    void Start()
    {
        bola = GameObject.Find("ball");
        score1 = 0;
        score2 = 0;


    }

    // Update is called once per frame
    void Update()
    {
        
        if (bola.transform.position.x >= 8.9f)
        {
            score1++;
            if(score1 >= 3)
            {
                Debug.Log("player1Win");
                p1win.SetActive(true);
                score1 = 0;
                ReLoad();
            }

        }
        if (bola.transform.position.x <= -8.9)
        {
            score2++;
            if (score2 >= 3)
            {
                Debug.Log("player2Win");
                p1win.SetActive(true);
                score2 = 0;
                ReLoad();
            }
        }
        Score.text = score1.ToString() + " - " + score2.ToString();        
        

    }
    
     private void ReLoad()
    {
        SceneManager.LoadScene("SampleScene");
    }


}
