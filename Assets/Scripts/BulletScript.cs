using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum bulletTypes { Player, EnemyN}
[RequireComponent(typeof(Rigidbody2D))]

public class BulletScript : MonoBehaviour {
    public bulletTypes mType;
    public float speed;
    Rigidbody2D rbody;
    public float destroyTime;

	void Start ()
    {
        rbody = GetComponent<Rigidbody2D>();
        Invoke("SelfDestruct", destroyTime);
	}
	
	void FixedUpdate ()
    {
        rbody.velocity = (Vector2)transform.TransformDirection(Vector3.up) * speed;
	}

    void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
