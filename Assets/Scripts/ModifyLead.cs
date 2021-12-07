using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModifyLead : MonoBehaviour
{
	private TextMeshProUGUI tmp;
    private string comando;
	
	public void SetLine(int mod){
		tmp = gameObject.GetComponent<TextMeshProUGUI>();
		if(mod == 1){ comando = "Testo"; }
		else{ comando = "Colore"; }
		tmp.text = comando;		
	}
}
