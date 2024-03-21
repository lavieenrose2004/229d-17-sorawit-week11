using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomentOfInertia : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Debug.Log(this.name + "Inertia" + GetComponent<Rigidbody>().inertiaTensor);
        transform.localScale += new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        //GetComponent<Rigidbody>().AddTorque(10, 0, 0);
        rb.angularVelocity = rb.inertiaTensor;

    }//FixedUpdate

}//MomentOfInertia
