using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myrigidbody2D;
    public float flapstrength ;
    public Logicscript logic;
    public bool isalive=true;

 void Start()
    {
        logic=GameObject.FindGameObjectWithTag("logic").GetComponent<Logicscript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isalive)
        {
            myrigidbody2D.linearVelocity = Vector2.up * flapstrength;
        }
       
    }
     private void OnCollisionEnter2D(Collision2D collision)
        {
            logic.gameover();
        isalive=false;
        }
}
