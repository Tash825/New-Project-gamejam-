using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourrandomizer : MonoBehaviour
{
    public MeshRenderer MeshRenderer;  
    void Start()
    {
        MeshRenderer.color = random.ColorHSV();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
