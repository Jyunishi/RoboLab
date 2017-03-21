using UnityEngine;
using System.Collections;

public class MenuScripts : MonoBehaviour {

	public void LoadNewScene(string lvlName){
		Application.LoadLevel (lvlName);
	}

}
