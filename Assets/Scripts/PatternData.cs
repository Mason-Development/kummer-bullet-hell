using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternData : MonoBehaviour {
    public int bulletsInPattern; //How many bullets will be fired in this attack
    public float[] rotations; //Where the turret will rotate too, edit in editor
    public float bulletSpeed; //How fast the bullets in this attack will travel 
    public float destroyTime; //How long until the bullet is destroyed (Set low when firing fast to avoid frame drops)

    void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
