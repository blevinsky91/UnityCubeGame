
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // this refers to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 1000f; //applying a forward force
    public float sidewaysForce = 500f; // applying a sideways force 

    // we changed this to FixedUpdate because we are using it to apply physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //add a forward force

        if (Input.GetKey("d")) //conditional to move player forward
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) // conditional to move player sideways
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindFirstObjectByType<GameManager>().EndGame();
        }
    }
}
