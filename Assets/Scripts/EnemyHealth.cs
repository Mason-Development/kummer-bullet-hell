using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public int maxHP;
	public int curHP;

	//Animator anim;

	void Start () 
	{
		curHP = maxHP;	
	}
	

	void OnTriggerEnter2D (Collider2D col) 
	{
		if (col.GetComponent<BulletScript> ().mType == bulletTypes.Player) 
		{
			TakeDamage (col.GetComponent<BulletScript> ().damage);
			Destroy (col.gameObject);
		}
	}

	void TakeDamage(int damage)
	{
		if (curHP > 0) 
		{
			curHP -= damage;
		} 
		else 
		{
			Death ();
		}
	}

	void Death()
	{
		//Explosion
		Destroy(gameObject);
	}
}
