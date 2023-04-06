using UnityEngine;

public class Failure : MonoBehaviour {

    public Transform destination;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            other.transform.position = destination.position;
        }
    }
}