using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeline : MonoBehaviour
{
    public Slider sd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sd.value -= 1;
        if (sd.value == 0) {
            
        }
    }
}
