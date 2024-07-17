using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float power = 10;
    public Rigidbody PlayerRB;
    public GameObject Cam;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            PlayerRB.AddForce(Cam.transform.forward * power);

        } 
        if (Input.GetKey(KeyCode.S))
        {
            PlayerRB.AddForce(Cam.transform.forward * -1 * power);

        }
    }
}
