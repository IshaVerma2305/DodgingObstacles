
using UnityEngine;

public class followplayer : MonoBehaviour
{
    public Vector3 offset; 
   public Transform player;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
