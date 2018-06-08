using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour {
    //Coordinates
    int x, y, xdelta, ydelta;
    Vector3 pos;
    //Direction
    Direction headDir;

    //Shooting
    public GameObject shot;
    public Text ammon;
    public int ammo;

	// Use this for initialization
	void Start () {
        //Spawnpoint and heading
        y = 0;
        x = 0;
        headDir = Direction.North;
        ammo = 5;
        ammon.text = ammo + "/5";
        
   
	}
    //Set Direction
    public void SetDir(int i)
    {
        switch (i)
        {
            case 1:
                headDir = Direction.East;
                break;
            case 2:
                headDir = Direction.South;
                break;
            case 3:
                headDir = Direction.North;
                break;
            case 4:
                headDir = Direction.West;
                break;

        }
    }

    //Movement
    public void SetXSpeed(int speed)
    {
        xdelta = speed;

    }
    public void SetYSpeed(int speed)
    {
        ydelta = speed;

    }
    //Shooting
    public void Shoot()
    {
        if (ammo > 0)
        {
            shot.GetComponent<MoveShot>().setShot(this, headDir);
            Instantiate(shot);
            ammo--;
            ammon.text = ammo + "/5";

        }
        
        
    }
    public void Reloadammo()
    {
        ammo = 5;
        ammon.text = ammo + "/5";
    }

    
        
    
    // Update is called once per frame
    void Update () {
        //Movement
        x = x + xdelta;
        y = y + ydelta;
        pos = new Vector3(x, y, 0);
        transform.SetPositionAndRotation(pos, transform.rotation);
     
	}
 
}
