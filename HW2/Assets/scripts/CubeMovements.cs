using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovements : MonoBehaviour
{
    public float rotationsSpeed = 100.0f;
    public float transeSpeed = 3.0f;
    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * rotationsSpeed * Time.deltaTime, 0);
        transform.Translate(Input.GetAxis("Horizontal") * transeSpeed * Time.deltaTime, 0, Input.GetAxis("Vertical") * transeSpeed * Time.deltaTime);
    }
}

