using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternData : MonoBehaviour {
    public int bulletsInPattern;
    public float[] rotations;
    public float bulletSpeed;
    public float destroyTime;

    void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
