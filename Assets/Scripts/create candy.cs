using UnityEngine;
using UnityEngine.InputSystem;

public class createcandy : MonoBehaviour
{
    // アクセス修飾子　型　変数名　＝　初期値
    private int CandyCount = 0;
    public GameObject CandyPrefab;
    //GameObjectの配列を作成
    public GameObject[] CandyPrefabs;

    // 課題のとこ
    //public float speed = 1.0f;
    //public float CreateCandyMoveRenge = 4.0f;
    //private Vector3 startPosition;

    void AddCandy()
    {
        // ここに処理が入る
        // 2＋1の結果をCandyCountに格納する
        CandyCount = CandyCount + 1;
        // 左のCandyCountは変数　右のCandyCountは変数の中の数字

        Debug.Log(CandyCount);
        //0から99までのランダムな整数を取得（百分率用）
        int rand = Random.Range(0, 100);
        int candyType = 0;

        //それぞれの当選確率
        //もしもrendが50未満ならcandyTypeを０
        if (rand < 5)
        {
            candyType = 0;
        }
        else if (rand < 80)
        {
            candyType = 1;
        }
        else if (rand < 99)
        {
            candyType = 2;
        }

        // オブジェクトの生成方法
        // Instantiateは(引数)を指定しないと動かない
        // 型　変数　初期値(Instantiateで作られたオブジェクト)
        GameObject createPrefab = Instantiate(CandyPrefabs[candyType]);
        // position
        createPrefab.transform.position = this.transform.position;

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        // 処理をあいたい関数名を書く
        //　関数呼び出しには（）が必要
        AddCandy();
        
        //startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // if文　もしも（条件）がtrueならば｛｝の処理をする
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            AddCandy();
        }

        //float x = Mathf.Sin(Time.time * speed) * CreateCandyMoveRenge;
        //this.transform.localPosition = startPosition + new Vector3(x, 0, 0);
    }
}

//public class Timer : MonoBehaviour
//{
    //public float span = 1f;
    //private float currentTime = 0f;

   // private void Update()
   // {
        // += Time.deltaTime;
        //if (currentTime > span) {
            //Debug.LogFormat("{1}秒経過", span);
            //currentTime = 0f;
        //}
      // }
   // }
//}