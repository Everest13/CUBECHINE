using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerBehavior behavior;
    public GameManager gameManager;

    //Restart Game, if player collision on obstacle
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            behavior.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
          
    }
}
