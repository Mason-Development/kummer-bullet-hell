using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
	
	public float speed;

	public Transform Player;

	void Update () 
	{
		Vector3 des = new Vector3 (Player.position.x, transform.position.y, transform.position.z);
		transform.position = Vector3.Lerp(transform.position, des, speed);
	}
}
