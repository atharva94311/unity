using UnityEngine;

public class triggerscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Logicscript logic;
    void Start()
    {
        logic=GameObject.FindGameObjectWithTag("logic").GetComponent<Logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer==3)
       {logic.addscore();}

    }
}
