using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;
    public string up;
    public string down;

    Rigidbody2D rBody;
    public Boundry boundry = new Boundry();

    [System.Serializable]
    public class Boundry
    {
        public float yMin, yMax, xMin, xMax;
    }

	// Use this for initialization
	void Start () {
        rBody = this.GetComponent<Rigidbody2D>();
	}

    void FixedUpdate()
    {
        float moveVertical = 0;

        

        if (Input.GetKey(up))
        {
            moveVertical = speed;
        }
        if (Input.GetKey(down))
        {
            moveVertical = speed * -1;
        }
        float moveHorizontal = 0;
        //float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        
        rBody.velocity = movement * speed;
        rBody.position = new Vector2(Mathf.Clamp(rBody.position.x, boundry.xMin, boundry.xMax), Mathf.Clamp(rBody.position.y, boundry.yMin, boundry.yMax));
    }

	// Update is called once per frame
	void Update () {
		
	}
}
