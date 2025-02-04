using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInput : MonoBehaviour
{

    public KeyCode keypress;

    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //if (Input.GetKeyDown(KeyCode.Space))
        {
            // Debug.Log("Bang!");
        }
       //if (Input.GetKeyUp(KeyCode.Space))
        {
            //Debug.Log("Bang key released!");
        }
        if (Input.GetKeyDown(keypress))
        {
            // Change the position to some random x and y location
            Vector3 position = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0);
            transform.SetPositionAndRotation(position, Quaternion.identity);
        }
        // Vector3 postion = new Vector3 (Random.Range(xMin, xMax), Random.Range(yMx, yMi), 0);
    }
}
