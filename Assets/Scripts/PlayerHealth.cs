using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI; /*In the future, we will probably want health bars*/

public class PlayerHealth : MonoBehaviour {

	public int maxHealth;
	public int curHealth;

	Animator anim;

 /* #region uiElements
  public Image healthBar;
  public Image remainingHealth;
  #endregion*/

	void Start()
	{
		anim = GetComponent<Animator> ();
		curHealth = maxHealth;
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.GetComponent<BulletScript> ().mType != bulletTypes.Player) 
		{
			TakeDamage (col.GetComponent<BulletScript>().damage);
			Destroy (col.gameObject);
		}

	}
	public void TakeDamage (int damage) 
	{
		if (curHealth > 0) 
		{
			curHealth -= damage;
			//Change health bar to mirror health
			//Player flashing??
			anim.SetTrigger("Hurt");
		} 
		else 
		{
			Death ();
		}
	}

	void Death()
	{
		//Preferable explosion particles
		//Game over menu
		GetComponent<PlayerMovement>().canMove = false;
	}
}
