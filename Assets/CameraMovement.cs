using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	private Transform player;
	
	
	void Start ()
	{
		player = GameObject.Find("Player 1").transform;
	}

	void Update ()
	{
		Vector3 playerPosition = player.position;
		playerPosition.z = transform.position.z;
//		position.x = 0;
//		position.y = transform.position.y;
		transform.position = playerPosition;
	}
}
