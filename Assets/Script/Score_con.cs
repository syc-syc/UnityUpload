using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_con : MonoBehaviour
{
    public int score;
    public Text ScoreUI;
    public GameObject win;
    private Enemy_CON Gameend;
    private Enemy_con1 Gameend1;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        win.SetActive(false);
        Gameend = GameObject.Find("GameManager").GetComponent<Enemy_CON>();
        Gameend1 = GameObject.Find("GameManager").GetComponent<Enemy_con1>();

    }

    // Update is called once per frame
    void Update()
    {
        ScoreUI.text = "Score:" + score.ToString();
        if(score >=50 )
        {
            Gameend1.enabled = false;
            Gameend.enabled = false;
            win.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
