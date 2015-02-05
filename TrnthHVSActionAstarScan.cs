using UnityEngine;
using System.Collections;

public class TrnthHVSActionAstarScan : TrnthHVSAction {
	protected override void _execute(){
		base._execute();
		AstarPath.active.Scan();
	}
}
