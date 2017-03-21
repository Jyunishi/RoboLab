using UnityEngine;
using System.Collections;

public class FieldController : MonoBehaviour {


	public GameObject[] TileArray;

	int MapSizeX = 11, MapSizeY = 11;
	float OffsetX = 0.05f, OffsetY = 0.05f;

	void GenerateMap()
	{
		for (int i = 0; i < MapSizeX; i++) {
			for (int j = 0; j < MapSizeY; j++) {
				Instantiate (GetPrefab(), new Vector3 (i + OffsetX*i, j + OffsetY*j, 0), Quaternion.identity);		
			}
		}
	}

	GameObject GetPrefab(){
		return TileArray [0];
	} 

	void Start () {
		GenerateMap();
	}
	
	void Update () {
	
	}
}
