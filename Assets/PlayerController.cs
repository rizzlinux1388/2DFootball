using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	public float speed = 10;

	public KeyCode moveUp;
	public KeyCode moveDown;
	public KeyCode moveRight;
	public KeyCode moveLeft;
	public KeyCode spinMove;
	Vector3 ballPos;
	

	public Transform ball;

	void Start ()
	{
		ball = GameObject.Find("Ball").transform;
	}

	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(moveUp))
		{
			GetComponent<Rigidbody2D>().AddForce(transform.up * speed);
		}
		else if (Input.GetKey(moveDown))
		{
			GetComponent<Rigidbody2D>().AddForce(transform.up * -speed);
		}

		if (Input.GetKey(moveRight))
		{
			GetComponent<Rigidbody2D>().AddForce(transform.right * speed);
		}
		else if (Input.GetKey(moveLeft))
		{
			GetComponent<Rigidbody2D>().AddForce(transform.right * -speed);
		}

	}

//	void OnTriggerEnter2D(Collider2D pickUp)
//	{
//		if (pickUp.gameObject.tag == "Ball")
//		{
//			pickUp.transform.position = gameObject.transform.position;
//			Debug.Log("Ball picked up");
//
//		}
//	}

	void OnTriggerStay2D(Collider2D pickUp)
	{
		if (pickUp.gameObject.tag == "Ball")
		{
			pickUp.GetComponent<Renderer>().sortingOrder = 2;
			if (Input.GetKeyDown(spinMove))
			{
				pickUp.isTrigger = false;
//				pickUp.GetComponent<Rigidbody2D>().AddForce(pickUp.transform.up * 100);

			}
		}
	}

	void OnCollisionEnter2D(Collision2D pickUp){
		if (pickUp.collider.gameObject.tag == "Ball")
		{
			Debug.Log("Collision detected!");
			//pickUp.transform.position = gameObject.transform.position;


		}
	}

}
