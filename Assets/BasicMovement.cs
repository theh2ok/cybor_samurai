using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    Rigidbody myrigi;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        myrigi=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        myrigi.velocity=new Vector3(Input.GetAxis("Horizontal")* speed, 0, Input.GetAxis("Vertical") * speed);

    }
}
