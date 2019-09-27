using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManagement : MonoBehaviour
{
    public static ScoreManagement scoreManagement;
    public Text scoretext;

    int score = 0;

    void Start()
    {
        if(scoreManagement == null)
        {
            scoreManagement = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (scoretext == null)
        {
            scoretext = GameObject.Find("Text").GetComponent<Text>();
            scoretext.text = score + "";
        }
    }

    public void RaiseScore(int s)
    {
        score += s;
        scoretext.text = score + "";
        if(score == 5)
        {
            SceneManager.LoadScene("Scene2");
        }
    }
}
