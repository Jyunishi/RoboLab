using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	public int speed = 10;
	private Animator anim;
	private float MoveOffset = 1.05f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	}


	void MovePlayer(Vector3 MoveDirection){
		gameObject.transform.Translate (MoveDirection * MoveOffset);
	}

	void FixedUpdate(){
	//	float move = Input.GetAxis ("Horizontal");
		//	anim.SetFloat ("Speed", 0);
	//	if (Input.GetButtonDown ("Right")) {
	//		anim.SetFloat ("Speed", 1);
	//		gameObject.transform.Translate (new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 1f, gameObject.transform.position.z));
	//	}


		if (Input.GetButtonDown ("Right")) { MovePlayer (Vector3.right);
			//gameObject.transform.Translate (Vector3.right * MoveOffset);	
		}else if (Input.GetButtonDown ("Left")) {MovePlayer (Vector3.left);
			//gameObject.transform.Translate (Vector3.left * MoveOffset);	
		}else if (Input.GetButtonDown ("Up")) {MovePlayer (Vector3.up);
			//gameObject.transform.Translate (Vector3.up * MoveOffset);	
		}else if (Input.GetButtonDown ("Down")) {MovePlayer (Vector3.down);
			//gameObject.transform.Translate (Vector3.down * MoveOffset);	
		}	
			
	}
}
