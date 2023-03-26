
using UnityEngine;

public class Playercollission : MonoBehaviour
{
    public player_movement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
     if (collisionInfo.collider.tag == "power-up")
        {
            Grow();
            
        }
    }
}
