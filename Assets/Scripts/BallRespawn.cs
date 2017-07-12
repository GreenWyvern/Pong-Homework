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
        if (other.tag == "DEAD1")
        {
            //Destroy(this.gameObject);
            leftWin += 1;
            Instantiate(this.gameObject, new Vector2(0, 0), this.transform.rotation);

        }
        if (other.tag == "DEAD2")
        {
            //Destroy(this.gameObject);
            rightWin += 1;
            Instantiate(this.gameObject, new Vector2(0, 0), this.transform.rotation);
        }
        
    }

    // Update is called once per frame
    void Update () {
		
	}
}
