using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myrigidbody2D;
    public float flapstrength ;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myrigidbody2D.linearVelocity = Vector2.up * flapstrength;
        }
    }
}
