using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class controler_maze : MonoBehaviour
{
    //public Button left, right,up,down;
    float dirx;
    float diry;
    public float movespeed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //down.onClick.AddListener(move_down);
        //up.onClick.AddListener(move_up);
        //left.onClick.AddListener(move_left);
        //right.onClick.AddListener(move_right);
    }
     void Update()
    {
        dirx = CrossPlatformInputManager.GetAxis("Horizontal");
        diry = CrossPlatformInputManager.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirx * movespeed, 0.0f , diry * movespeed);
    }
    
    // Update is called once per frame
    
}
