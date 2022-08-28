using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    // Start is called before the first frame update
    string[] colors = { "green", "blue", "yellow", "red", "black" };
    public string color = "red";
    public GameObject door;
    
	private void OnTriggerExit(Collider other)
	{
        color = colors[Random.Range(0, 5)];
        Debug.Log(color);
        door.SetActive(false);
    }
}
