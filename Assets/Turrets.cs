using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrets : MonoBehaviour {
    public float coolDown; //Time before each bullet is fired
    float curCoolTime;
    public float attackTimer; //Time before the attack can start, resets after every attack is complete

    public GameObject bulletPref;
    public PatternData[] attacks;
    int curAttack; //Attacks will be run based on order of attack array, then reset one it reaches the last one

    public float damping;

    void Start ()
    {
		
	}
	
	void Update ()
    {
      
	}

    public void SpawnBullet(int ID, int rotNum)
    {
        //Rotating turret to proper place
        transform.rotation = Quaternion.Slerp(transform.rotation, attacks[ID].rotations[rotNum], damping);
        Instantiate(bulletPref, transform.position, transform.rotation);
    }
}
