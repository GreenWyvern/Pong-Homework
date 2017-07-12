using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LeftScore : MonoBehaviour {

    [SerializeField]
    Text scoreText;

    void UpdateScoreText()
    {
        if(BallRespawn.leftWin < 11 && BallRespawn.rightWin < 11) { 
        scoreText.text = "     " + BallRespawn.rightWin.ToString() + "        " + BallRespawn.leftWin.ToString();
        }
        if(BallRespawn.leftWin >= 11)
        {
            scoreText.text = "RIGHT PLAYER WINS!";
            BallRespawn.rightWin = 0;
        }
        if (BallRespawn.rightWin >= 11)
        {
            scoreText.text = "LEFT PLAYER WINS!";
            BallRespawn.leftWin = 0;
        }
    }

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        UpdateScoreText();

    }
}
