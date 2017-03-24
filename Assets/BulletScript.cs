using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum bulletTypes { Player, EnemyN}
[RequireComponent(typeof(Rigidbody2D))]

public class BulletScript : MonoBehaviour {
    public bulletTypes mType;
    public float speed;
    Rigidbody2D rbody;

	void Start ()
    {
        rbody = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate ()
    {
        rbody.velocity = Vector2.down * (speed + Time.deltaTime);
	}
}
