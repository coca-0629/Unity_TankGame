using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_turret_move : MonoBehaviour
{
    [SerializeField]
    private float power = 1200.0f;
    public Transform bullet;
    public Transform target;
    public Transform sp_point;

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(target);
    }
}
