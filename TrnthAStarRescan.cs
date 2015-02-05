using UnityEngine;
using System.Collections;

public class TrnthAStarRescan : MonoBehaviour {
	public float delayBetween=5;
	void execute(){
		if(!AstarPath.active)return;
		AstarPath.active.Scan();
		Invoke("execute",delayBetween);
	}
	void Start(){
		execute();
	}
}
