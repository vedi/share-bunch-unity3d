using UnityEngine;
using System.Collections;

public class ShareSceneController : MonoBehaviour {

	void Start () {
		ShareBunch.GetInstance().ShareText("I'm sharing the text");
	}
	
}
