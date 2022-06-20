using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public int score;
    public int Level=1;
    public int bestScore;

    public TextMeshProUGUI scoreGUI;
    public TextMeshProUGUI levelGUI;
    public TextMeshProUGUI bestScoreGUI;
    
    float timer = 0.0f;

    void Start()
    {
        instance = this;
        bestScore = PlayerPrefs.GetInt("BestScore");
    }

    public void Save()
    {

        if (score >= bestScore)
        {
            bestScore = score;
        }

        PlayerPrefs.SetInt("BestScore",bestScore);
       
    }
    
    void Update()
    {
        if (GameManager.instance.condition == false) return;

       

        timer += Time.deltaTime;
        if(timer>=1.0f)
        {
           
          switch(Level)
            {
                case 1:
                    score += 1;
                    break;
                case 2:
                    score += 2;
                    break;
                case 3:
                    score += 3;
                    break;
            }
            timer = 0.0f;
            
        }
        scoreGUI.text = "Score : "+score.ToString();
        levelGUI.text = "Level " + Level.ToString();
        bestScoreGUI.text = "Best Score : " + bestScore.ToString();
    }
}
