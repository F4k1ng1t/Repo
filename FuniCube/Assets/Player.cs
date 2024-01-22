using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    float s = 0.1f;
    void Start()
    {

    }
    public float GetSpeed()
    {
        return s;
    }
    float SpeedUp()
    {
        s += 0.01f;
        return s;
    }
    float SlowDown()
    {
        s -= 0.01f;
        return s;
    }
    // Update is called once per frame
    void Update()
    {
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
			SpeedUp();
		}
		if (Input.GetKey(KeyCode.O) && s > 0)
		{
            SlowDown();
		}
		
    }
}
