using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    int x, y;
    public bool u, d, r, l;
    Vector3 pos;
    Button up, down, left, right;
	// Use this for initialization
	void Start () {
        y = 0;
        x = 0;
   
	}
	
	// Update is called once per frame
	void Update () {
        
        if (u)
        {

        }else if (d)
        {

        }else if (r)
        {
            x = x + 1;
            pos = new Vector3(x, y, 0);
            transform.SetPositionAndRotation(pos, transform.rotation);
        }else if (l)
        {

        }

        pos = new Vector3(x, y, 0);
        this.transform.SetPositionAndRotation(pos, this.transform.rotation);
     
	}
 
}
