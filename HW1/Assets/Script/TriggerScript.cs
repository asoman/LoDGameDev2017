using UnityEngine;

public class TriggerScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if(other.gameObject.name == "Player")
        {
            GetComponent<Light>().intensity = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Player")
        {
            GetComponent<Light>().intensity = 1;
        }
    }

}
