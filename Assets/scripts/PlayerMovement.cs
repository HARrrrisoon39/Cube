using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
    public float Forward = 2000f;
    public float sideWays = 500f;

    // Update is called once per frame
    void FixedUpdate () {
        rb.AddForce (0, 0, Forward * Time.deltaTime);
        if (Input.GetKey ("d")) {
            rb.AddForce (sideWays * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey ("a")) {
            rb.AddForce (-sideWays * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}