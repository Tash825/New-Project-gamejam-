using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float forwardspeed;
    public GameObject winnerpanel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(forwardspeed*Time.deltaTime, 0, 0);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "enemy")
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        if (collision.collider.tag == "win")
        {
            winnerpanel.SetActive(true);
        }
    }
    public void leftmovebutton()
    {
        transform.Translate(0, 0, speed);
    }
    public void rightmovebutton()
    {
        transform.Translate(0, 0, -speed);
    }

}
