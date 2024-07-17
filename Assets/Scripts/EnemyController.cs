using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float power = 10;
    public Rigidbody EnemyRB;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        EnemyRB = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Place = (Player.transform.position - transform.position).normalized;
        EnemyRB.AddForce(Place * power);
    }
}
