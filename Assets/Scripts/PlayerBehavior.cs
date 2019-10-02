using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehavior : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 60f;

    // We marked this as "FixedUpdate", because we are using it to mess with physics.
    void FixedUpdate()
    {       
        //Add a fowrard force
        rb.AddForce(0, 0 , forwardForce * Time.deltaTime);

        if ( Input.GetKey("d")) //If the player is pressing "d" key
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) //If the player is pressing "a" key
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) //If the player is fallen from platform
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
