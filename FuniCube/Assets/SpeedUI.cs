using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpeedUI : MonoBehaviour 
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Player p;
    

    // Update is called once per frame
    void Update()
    {
        float s = p.GetSpeed();
        string f = $"Speed: {s}";
        Debug.Log(f);
    }
}
