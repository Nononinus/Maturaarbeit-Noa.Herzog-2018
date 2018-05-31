using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShot : MonoBehaviour {
    //Movement
    int xDelta, yDelta;
    public Player p;
    public Direction direction;

	public void setShot(Player p, Direction direction)
    {
        this.p = p;
        this.direction = direction;
    }
	void Start () {
        Vector3 pos = p.transform.position;
        transform.SetPositionAndRotation(pos, transform.rotation);
        switch (direction)
        {
            case Direction.North:
                yDelta = 1;
                xDelta = 0;
                break;
            case Direction.South:
                yDelta = -1;
                xDelta = 0;
                break;
            case Direction.East:
                yDelta = 0;
                xDelta = 1;
                break;
            case Direction.West:
                yDelta = 0;
                xDelta = -1;
                break;


        }
	}
	
	// Update is called once per frame
	void Update () {
        float x = transform.position.x + xDelta;
        float y = transform.position.y + yDelta;
        Vector3 pos = new Vector3(x, y, 0); 
        transform.SetPositionAndRotation(pos, transform.rotation);
    }
}
