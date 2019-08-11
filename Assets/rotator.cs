using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{ //public  gameobject Sphere;
    public float radius = 1.0f;
    float timeCounter = 0;
    private Vector3 _startLocation;
    //public Rigidbody rb;
    public float speed_up = 5.0f;
     float h = 1.0f;
    public Transform cube;
    // Start is called before the first frame update

    Quaternion q = Quaternion.AngleAxis(50, Vector3.up);
    // Update is called once per frame
    public void rotateRigidBodyAroundPointBy(Rigidbody rb, Vector3 origin, Vector3 axis, float angle)
    {
        Quaternion q = Quaternion.AngleAxis(angle, axis);
        rb.MovePosition(q * (rb.transform.position - origin) + origin);
        rb.MoveRotation(rb.transform.rotation * q);
    }

    

   
    private float _tick = 0;
    
    

    void Update()
    {
        

            if (Input.GetKeyDown(KeyCode.Space))
        {
            cube.transform.Rotate(1.0f, 0f, 0f);
            // rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        }
    }

    // rb.velocity = Quaternion.AngleAxis(timeCounter, Vector3.up   ) * new Vector3(radius, 0, 0);
    // if (Input.GetKeyDown(KeyCode.Space))
    // { //transform.Translate(Vector3.up * Time.deltaTime*10);
    //  transform.RotateAround(sphereOne.transform.position, new Vector3(0, 1, 0), 100 * Time.deltaTime);
    //transform.position = Quaternion.AngleAxis(timeCounter, Vector3.up*10)  * new Vector3(radius, 0,0);


    //  }
}

