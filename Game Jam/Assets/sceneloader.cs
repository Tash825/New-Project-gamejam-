using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject instruction;
    public GameObject instructionpanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playgame()
    {
        SceneManager.LoadScene(1);
        
    }
    public void instructionpanelbutton()
    {
        instruction.SetActive(false);
        instructionpanel.SetActive(true);
    }
}
