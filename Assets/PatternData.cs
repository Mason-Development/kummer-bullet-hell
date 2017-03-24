using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternData : MonoBehaviour {
    public int bulletsInPattern;
    public Quaternion[] rotations;
    public float bulletSpeed;

    void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
