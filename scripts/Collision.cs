
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{

    public PlayerMovement movement;
   
    void OnCollisionEnter(Collision collision)
    {
if(collision.collider.tag == "obstacle")
{
   // Debug.Log("We hit an obstacle");
    movement.enabled = false;
    FindObjectOfType<GameManager>().EndGame();
}
    }
}
