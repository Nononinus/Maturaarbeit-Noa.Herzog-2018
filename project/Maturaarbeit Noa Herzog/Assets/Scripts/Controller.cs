using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;


public class Controller : MonoBehaviour, IPointerDownHandler , IPointerUpHandler
{
    public Button right;
    public GameObject p;
    Player pl;
	// Use this for initialization
	void Start () {
        pl = p.GetComponent<Player>();
	}


    // Update is called once per frame
    void Update() {
    }
	public void OnPointerDown(PointerEventData e){
        if (e.button.Equals(right)){
            pl.r = true;
        }
                    
    }

    public void OnPointerUp(PointerEventData e){
        if (e.button.Equals(right)){
            pl.r = false;
        }
    }
}
