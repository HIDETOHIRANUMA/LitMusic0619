using UnityEngine;
using System.Collections;

public class instaRight : MonoBehaviour {

	//曲のタイミングデータを宣言
	float[] timing=  {1.5f,2.2f,2.5f,2.9f,3.6f,4.3f,4.7f,5.1f,5.4f,5.8f,6.5f,7.2f,7.8f,8.3f,8.7f,9.2f,9.8f,10.1f,10.7f,11.2f,11.6f,11.7f,11.978f,12.1f,12,3f,100f};
	int i=0;


	//曲の判定結果を格納しておく変数を宣言。
	public static int cool; public static int good; public static int bad;

	//エフェクトを格納。
	public GameObject goodEffect;
	public GameObject badEffect;
	public GameObject copybar;

	//GameObject original = GameObject.Find("Mleft");

	// Use this for initialization
	void Start () {
		//result = Math.Round(1.405m, 2, MidpointRounding.AwayFromZero);
		//Console.WriteLine(result); // 出力：1.41
	
		cool = 0; good = 0;bad = 0;

	}



	float timer=0.0f;
	// Update is called once per frame
	void Update () {
		
		timer = timer + Time.deltaTime;
		Debug.Log (timer);

		for (i = 0; i <= 15; i++) 
		{
			if ((timing[i]-0.01f)<timer&&timer<(timing[i]+0.01f)) {
				//GameObject copied = Object.Instantiate (original) as GameObject;
				//copied.transform.Translate (0, 0, 0);
				Instantiate(copybar);

			}
		//}
		}

}
}

