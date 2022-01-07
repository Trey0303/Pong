using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text p1Score;
    private Text p2Score;

    public GameObject p1Winscreen;
    public GameObject p2Winscreen;

    public int curP1Score;
    public int curP2Score;

    public int maxPoints = 7;

    // Start is called before the first frame update
    void Start()
    {
        Data.GameOver = false;

        Data.P1Score = 0;
        Data.P2Score = 0;

        p1Score = GameObject.Find("LeftScore").GetComponent<Text>();
        p1Score.text = "" + Data.P1Score;
        curP1Score = Data.P1Score;

        p2Score = GameObject.Find("RightScore").GetComponent<Text>();
        p2Score.text = "" + Data.P2Score;
        curP2Score = Data.P2Score;

        if (!Data.GameOver)
        {
            p1Winscreen.SetActive(false);
            p2Winscreen.SetActive(false);
        }


    }

    // Update is called once per frame
    void Update()
    {
        if(Data.P1Score != curP1Score)
        {
            p1Score.text = "" + Data.P1Score;
            curP1Score = Data.P1Score;
        }

        if (Data.P2Score != curP2Score)
        {
            p2Score.text = "" + Data.P2Score;
            curP2Score = Data.P2Score;
        }

        //Debug.Log("P1: " + curP1Score);
        //Debug.Log("P2: " + curP2Score);

        if (curP1Score == maxPoints)
        {
            Data.GameOver = true;
            p1Winscreen.SetActive(true);
        }

        if(curP2Score == maxPoints)
        {
            Data.GameOver = true;
            p2Winscreen.SetActive(true);
        }

    }
}
