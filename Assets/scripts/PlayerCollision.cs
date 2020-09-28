using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public PlayerMovement movement;
    void OnCollisionEnter(Collision other) {
      if (other.collider.tag == "obstacle")
      {
        movement.enabled = false;
      //  Debug.Log("moron hit obstacle");  
         FindObjectOfType<GameManager>().EndGame();
      } 
    }
}