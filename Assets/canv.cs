using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canv : MonoBehaviour
{
	public Canvas canvass;
    // Start is called before the first frame update
    void Start()
    {
        canvass = GetComponent<Canvas>();
        canvass.worldCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
