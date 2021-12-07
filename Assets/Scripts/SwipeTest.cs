using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeTest : MonoBehaviour
{
    public Swipe swipeControls;
	public PathDetection way;
	private bool rightWay = false;
	//public Transform player;
	private Vector3 desiredPosition;

    // Update is called once per frame
    void Update()
    {
        if( swipeControls.SwipeLeft ){ desiredPosition += Vector3.left; }
		if( swipeControls.SwipeRight ){ desiredPosition += Vector3.right; }
		if( swipeControls.SwipeUp ){ desiredPosition += Vector3.forward; }
		if( swipeControls.SwipeDown ){ desiredPosition += Vector3.back; }
		
		//player.transform.position = Vector3.MoveTowards(player.transform.position, desiredPosition, 3f * Time.deltaTime);
		
		//if(swipeControls.Tap){ Debug.Log("Tap!"); }
		if(swipeControls.SwipeLeft){ 
			Debug.Log("Left!"); 
			if(way.Way == 1){
				Debug.Log("Corretto!");
				rightWay = true;
			}
		}
		if(swipeControls.SwipeRight){ 
			Debug.Log("Right!"); 
			if(way.Way == 2){
				Debug.Log("Corretto!");
				rightWay = true;
			}
		}
		if(swipeControls.SwipeUp){ 
			Debug.Log("Up!"); 
			if(way.Way == 3){
				Debug.Log("Corretto!");
				rightWay = true;
			}
		}
		if(swipeControls.SwipeDown){ 
			Debug.Log("Down!"); 
			if(way.Way == 4){
				Debug.Log("Corretto!");
				rightWay = true;
			}
		}
    }
	
	public bool Result { get { 
			if (rightWay == true){
				rightWay = false;
				return true; 
			}
			else return false;
		} 
	}
}
