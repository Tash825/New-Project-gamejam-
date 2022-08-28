using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float forwardspeed;
    public GameObject winnerpanel;
    public GameObject failedpanel;
    public GameObject it_not_panle;

    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(forwardspeed*Time.deltaTime, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10f, 47.6f), transform.position.y, Mathf.Clamp(transform.position.z, -1.5f, 2.4f));

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
        if (collision.collider.tag == "not_a_door")
        {
            failedpanel.SetActive(true);
            Time.timeScale = 0;
        }
        if (collision.collider.tag == "black")
        {
            it_not_panle.SetActive(true);
            Time.timeScale = 0;
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
    public void retrybutton()
    {
        SceneManager.LoadScene(0);
    }
}
