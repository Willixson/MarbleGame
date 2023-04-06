using UnityEngine;
using TMPro;

public class Win : MonoBehaviour {

    public TextMeshPro winText;
    public GameObject player;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            winText.SetText("You win!");
            player.GetComponent<MarbleController>().speed = 0;
            player.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}