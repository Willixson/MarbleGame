using UnityEngine;

public class MarbleController : MonoBehaviour {

    public float speed = 10.0f;

    void Update () {
        float moveHorizontal = Input.acceleration.x;
        float moveVertical = Input.acceleration.y;

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        GetComponent<Rigidbody>().AddForce(movement * speed);
    }
}