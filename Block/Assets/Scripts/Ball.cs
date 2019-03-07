using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    [SerializeField] Paddle paddle1;
    Vector2 paddleToBall;
    [SerializeField] float xVel;
    [SerializeField] float yVel;
    bool x;
	// Use this for initialization
	void Start ()
    {
        paddleToBall = transform.position - paddle1.transform.position;
        x = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (x)
        {
            LockBallToPaddle();
            x = ReleaseBall();
        }
        
    }

    private bool ReleaseBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, yVel);
            return false;
        }
        else
        {
            return true;
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBall;
    }
}
