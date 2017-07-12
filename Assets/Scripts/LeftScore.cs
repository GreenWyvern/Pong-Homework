using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LeftScore : MonoBehaviour {

    [SerializeField]
    Text scoreText;

    void UpdateScoreText()
    {
        scoreText.text = BallRespawn.leftWin.ToString();
    }

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        UpdateScoreText();

    }
}
