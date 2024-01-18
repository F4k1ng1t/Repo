using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	float s = 0.5;
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * s;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * s;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * s;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * s;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * s;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += Vector3.down * s;
        }
		if (Input.GetKey(KeyCode.P) && s <= 100)
		{
			s += 0.5;
		}
		if (Input.GetKey(KeyCode.O) && s >= 0)
		{
			s -= 0.5;
		}
		
    }
}
