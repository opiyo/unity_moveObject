using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Environment : MonoBehaviour {
	// 生成するPrefabをInspectorビューで設定
	[SerializeField] List<GameObject> itemPrefabs;


	void Start () {
		// 設定したitemPrefabsの数だけforループ
		for( int i = 0; i < itemPrefabs.Count; i++){
			// itemPrefabsを生成(Instantiate)
			// 生成位置xとyは-2〜2の範囲でランダムで生成
			GameObject obj = Instantiate(itemPrefabs[i],
				new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-2.0f, 2.0f), 0),
				Quaternion.identity) as GameObject;
			// Translateで動く数値(x, y)を設定
			// とりあえずループで使っている数値(0, 1, 2, 3...)を使用
			// ここを工夫して設定すれば、各オブジェクトを別々に動かすことが可能です。
			obj.GetComponent<MoveObject>().moveX = i;
			obj.GetComponent<MoveObject>().moveY = i;
		}
	}
}
