using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
	
	public float speed;

	Animator anim;

	public Transform Player;

	void Start()
	{
		anim = GetComponent<Animator> ();		
	}

	void Update () 
	{
		Vector3 des = new Vector3 (Player.position.x, transform.position.y, transform.position.z);
		transform.position = Vector3.Lerp(transform.position, des, speed);

		if (GetComponentInChildren<Turrets> () && GetComponentInChildren<Turrets> ().attacking) 
		{
			anim.SetBool ("Attack", true);
		} 
		else 
		{
			anim.SetBool ("Attack", false);
		}
	}
}
