using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class СollisionChecker : MonoBehaviour {

    Coroutine wait;

    private void Start()
    {
        wait = StartCoroutine(WaitOneSecond());
    }

    IEnumerator WaitOneSecond()
    {
        yield return new WaitForSeconds(1);
        StartCoroutine(Explosion());
    }

    void OnCollisionEnter() {
        Debug.Log("Я взорвалась!");
        StopCoroutine(wait);
        StartCoroutine(Explosion());
    }

    IEnumerator Explosion()
    {
        GetComponent<Rigidbody>().Sleep();
        GetComponent<Rigidbody>().useGravity = false;
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(0).gameObject.GetComponent<ParticleSystem>().Play(true);
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
