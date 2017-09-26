using UnityEngine;

public class CameraScript : MonoBehaviour {

    public float rotationSpeed = 45;

	void Start () {
       // Cursor.lockState = CursorLockMode.Locked;
       // Cursor.visible = false;
	}
	
	void Update () {
        transform.Rotate(-Input.GetAxis("Mouse Y") * Time.deltaTime * rotationSpeed, 0, 0);
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
	}
}
