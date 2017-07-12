using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    private Rigidbody2D rBody;
    public float speed;
    public float initial;


	// Use this for initialization
	void Start () {
       

        rBody = this.GetComponent<Rigidbody2D>();

        float moveHorizontal = 0;


        if (Random.value > 0.5)
        {
            moveHorizontal = 2.5f;
        }
        else
        {
            moveHorizontal = -2.5f;
        }

        float moveVertical = -initial + Random.value * initial * 2;

        //float myTime = 0.0f;
        //while (myTime < 2)
        //{
        //    myTime += Time.deltaTime;
        //    Vector2 noMovement = new Vector2(0, 0);
        //    rBody.velocity = noMovement * speed;
        //}

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);


        rBody.velocity = movement * speed;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Paddle")
        {
            //rBody = this.GetComponent<Rigidbody2D>();
            //rBody.velocity *= -1;
            

        }
    }

	// Update is called once per frame
	void Update () {

        rBody.freezeRotation = true;
    }
}
