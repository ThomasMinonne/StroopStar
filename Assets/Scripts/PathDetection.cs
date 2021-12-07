using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathDetection : MonoBehaviour
{
    private int way, starcolor, i;
	public GameObject[] stelle;
	public SwipeTest result;
	public ModifyLead line;
	public ChangeText tmp;
	private string color;
	private Vector3 position;
	private int mod;
	private string name;
	
	private string[] nomistelle = new string[]{"BlueStar(Clone)", "GreenStar(Clone)", "PinkStar(Clone)", "RedStar(Clone)", "YellowStar(Clone)"};
	private bool[] valid = new bool[]{true, true, true, true, true};
	
	// Start is called before the first frame update
    void Start()
    {
        generateLevel();
    }

    // Update is called once per frame
    void Update()
    {
        if( result.Result == true ){
			valid[0] = valid[1] = valid[2] = valid[3] = valid[4] = true;
 			for( i = 0; i < 4; i++){
				for( int y = 0; y < 5; y++){
					GameObject delete = GameObject.Find(nomistelle[y]);
					if(delete){ Destroy(delete.gameObject); }
				}
			}
			generateLevel();
		}
    }
	
	private void gameMod(){
		mod = Random.Range(0, 2);
		line.SetLine(mod);
		tmp.changeColorText(name, mod);
	}
	
	private void generateLevel(){
		way = Random.Range(1, 5);
		for( i = 1; i < 5; i++){
			starcolor = Random.Range(0, 5);
			while( valid[starcolor] == false ){
				starcolor = Random.Range(0, 5);
			}
			if(i == 1){
				position = new Vector3(-4, 0, 0);
				if( i == way ){
					name = stelle[starcolor].name;
				}
			}
			if(i == 2){
				position = new Vector3(4, 0, 0);
				if( i == way ){
					name = stelle[starcolor].name;
				}
			}
			if(i == 3){
				position = new Vector3(0, 4, 0);
				if( i == way ){
					name = stelle[starcolor].name;
				}
			}
			if(i == 4){
				position = new Vector3(0, -4, 0);
				if( i == way ){
					name = stelle[starcolor].name;
				}
			}
			Instantiate(stelle[starcolor], position, Quaternion.identity);
			valid[starcolor] = false;
		}
		Debug.Log(name);
		gameMod();
		Debug.Log(way);
	}
	
	public int Way { get { return way; } }
}
