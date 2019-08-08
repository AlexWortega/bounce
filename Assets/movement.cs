using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float X_trust = 10.0f ;
    public float Y_trust = 15.0f ;
    public Rigidbody chie;
    // Start is called before the first frame update
    void Start()
    {
        chie = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            chie.AddForce(new Vector3(X_trust, Y_trust, X_trust), ForceMode.Impulse);
        }
    }
}
