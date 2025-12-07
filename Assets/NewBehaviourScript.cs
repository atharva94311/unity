using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float movespeed=10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  transform.position = transform.position+ Vector3.left * movespeed*Time.deltaTime;
          if (transform.position.x < -45)
        {
            Destroy(gameObject);
      
    }
}
}