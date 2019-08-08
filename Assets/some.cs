using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class some : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    [SerializeField]
    private float hor;
    private float ver;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(hor, 0, ver) * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Time.timeScale = 0.1f;

        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Time.timeScale = 1.0f;
        }
    }

}
