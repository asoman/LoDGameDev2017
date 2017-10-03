using System.Collections;
using UnityEngine;

public class ThrowingGrenade : MonoBehaviour
{
    public GameObject grenadePrefab;
    bool isReadyToThrow = true;
    public GameObject trowingPossition;
    public GameObject cameraObject;
    public int speed = 500;

    // Update is called once per frame
    void Update()
    {
        if (isItPossibleToThrowGrenade()) { 
            Debug.Log("Pressed right click.");
            ThrowGrenade();
        }
    }

    bool isItPossibleToThrowGrenade()
    {
        return Input.GetMouseButtonDown(1) && isReadyToThrow;
    }

    void ThrowGrenade()
    {
        GameObject obj = Instantiate(grenadePrefab,
            trowingPossition.transform.position,
            trowingPossition.transform.rotation);
        Vector3 lookDir = cameraObject.transform.forward;
        obj.GetComponent<Rigidbody>().AddForce(lookDir * speed);
        StartCoroutine(TrowingCalldown());
        
    }

    IEnumerator TrowingCalldown()
    {
        isReadyToThrow = false;
        yield return new WaitForSeconds(1);
        isReadyToThrow = true;
    }
}
