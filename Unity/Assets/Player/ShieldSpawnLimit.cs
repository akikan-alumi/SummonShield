using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// シールドをあと何枚生成できるか
/// </summary>
public class ShieldSpawnLimit : MonoBehaviour {

	/// <summary>
	/// ClickPositionCreatePrefabScript
	/// </summary>
	private ClickPositionCreatePrefabScript CPCPS;

	/// <summary>
	/// 残シールド数を表示するテキスト
	/// </summary>
	[SerializeField]
	private Text shieldSpawnLimit;

	//現在生成されているWall
	private GameObject[] spawnedShields;

	private int spawnMax;
	void Awake()
	{
		//アタッチされているClickPositionCreatePrefabScript(CPCPS)を取得
		CPCPS = gameObject.GetComponent<ClickPositionCreatePrefabScript>();
	}

	// Use this for initialization
	void Start () 
	{
		spawnMax = CPCPS.SpawnMax;
		Debug.Log ("SpawnMax = " + spawnMax);
		spawnedShields = CPCPS.targets;
	}
	
	// Update is called once per frame
	void Update () 
	{
		UpdateShieldsuu ();
	}

	/// <summary>
	/// 残シールド数を更新
	/// </summary>
	private void UpdateShieldsuu()
	{
		spawnedShields = CPCPS.targets;
		int shields = (spawnMax - spawnedShields.Length);
		shieldSpawnLimit.text = shields.ToString();
	}
}
