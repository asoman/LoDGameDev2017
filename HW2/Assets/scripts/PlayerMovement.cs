using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed = 3;
    public float rotationSpeed = 3;


    public void saysmth()
    {
        Debug.Log("HI");
    }
	void Update () {
        transform.Rotate(0, Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime, 0);

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Camera.main.gameObject.GetComponent<Animator>().SetFloat("Speed", movement.magnitude * movementSpeed);
        movement *= Time.deltaTime * movementSpeed;
        movement = Vector3.ClampMagnitude(movement, movementSpeed);
        movement = transform.TransformDirection(movement);
        
        GetComponent<CharacterController>().Move(movement);

    }
}
