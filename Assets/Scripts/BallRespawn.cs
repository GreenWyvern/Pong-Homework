using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRespawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    static public int leftWin;
    static public int rightWin;
    public GameObject ball;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (leftWin == 10 || rightWin == 10)
        {
        if (leftWin == 10 && rightWin != 10)
        {
            if (other.tag == "DEAD1")
            {

                leftWin += 1;
                Destroy(this.gameObject);

            }
            if (other.tag == "DEAD2")
            {

                rightWin += 1;
                Instantiate(this.gameObject, new Vector2(0, 0), this.transform.rotation);
                Destroy(this.gameObject);
            }
        }
        else
        if (leftWin != 10 && rightWin == 10)
        {
            if (other.tag == "DEAD1")
            {

                leftWin += 1;
                Instantiate(this.gameObject, new Vector2(0, 0), this.transform.rotation);
                Destroy(this.gameObject);

            }
            if (other.tag == "DEAD2")
            {

                rightWin += 1;
                Destroy(this.gameObject);
            }
        }
        else
        if (leftWin == 10 && rightWin == 10)
        {
            if (other.tag == "DEAD1")
            {

                leftWin += 1;
                Destroy(this.gameObject);

            }
            if (other.tag == "DEAD2")
            {

                rightWin += 1;
                Destroy(this.gameObject);
            }
        }
        }
        else
        {
        if (leftWin < 11 && rightWin < 11) { 
            if (other.tag == "DEAD1")
            {
                
                leftWin += 1;
                Instantiate(this.gameObject, new Vector2(0, 0), this.transform.rotation);
                Destroy(this.gameObject);

            }
            if (other.tag == "DEAD2")
            {
                
                rightWin += 1;
                Instantiate(this.gameObject, new Vector2(0, 0), this.transform.rotation);
                Destroy(this.gameObject);
            }
        }
        }



    }

    // Update is called once per frame
    void Update () {
		
	}
}
