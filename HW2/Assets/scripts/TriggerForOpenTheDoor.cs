using UnityEngine;

public class TriggerForOpenTheDoor : MonoBehaviour {
    private bool _isOpen = false;
    public GameObject lightObject;
    public GameObject cameraObject;
    public GameObject door;
    public GameObject doorCube;
    void OnTriggerEnter(Collider other) {
        Debug.Log("EnteredTriggerForOpenTheDoor");
        lightObject.GetComponent<Light>().enabled = true;
        
    }

    void OnTriggerStay(Collider other) {
        if (IsItPossibleToOpenTheDoor()) {
            OpenTheDoor();
        }
    }

    bool IsItPossibleToOpenTheDoor()
    {
        if (!_isOpen && Input.GetKeyDown(KeyCode.F) &&
            cameraObject.GetComponent<LookDirection>().getNameOfObject() == doorCube.name)
            return true;
        else
            return false;
    }

    void OpenTheDoor() {
        door.transform.Rotate(0, 90, 0);
        _isOpen = true;
    }

    void CloseTheDoor()
    {
        door.transform.Rotate(0, -90, 0);
        _isOpen = false;
    }

    void OnTriggerExit(Collider other) {
        Debug.Log("ExitedTriggerForOpenTheDoor");
        lightObject.GetComponent<Light>().enabled = false;
        if (_isOpen) {
            CloseTheDoor();
        }
    }
}
