using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovements : MonoBehaviour {
    public float rotationsSpeed = 100.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Input.GetAxis("Mouse Y") * rotationsSpeed * Time.deltaTime, 0, 0);
    }
}
