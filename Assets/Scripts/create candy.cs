using UnityEngine;
using UnityEngine.InputSystem;

public class createcandy : MonoBehaviour
{
    // アクセス修飾子　型　変数名　＝　初期値
    private int CandyCount = 0;
    public GameObject CandyPrefab;

    // 課題のとこ
    public float speed = 1.0f;
    public float CreateCandyMoveRenge = 4.0f;
    private Vector3 startPosition;

    void AddCandy()
    {
        // ここに処理が入る
        // 2＋1の結果をCandyCountに格納する
        CandyCount = CandyCount + 1;
        // 左のCandyCountは変数　右のCandyCountは変数の中の数字

        Debug.Log(CandyCount);

        // オブジェクトの生成方法
        // Instantiateは(引数)を指定しないと動かない
        // 型　変数　初期値(Instantiateで作られたオブジェクト)
        GameObject createPrefab = Instantiate(CandyPrefab);
        // position
        createPrefab.transform.position = this.transform.position;

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        // 処理をあいたい関数名を書く
        //　関数呼び出しには（）が必要
        AddCandy();
        
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // if文　もしも（条件）がtrueならば｛｝の処理をする
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            AddCandy();
        }

        float x = Mathf.Sin(Time.time * speed) * CreateCandyMoveRenge;
        this.transform.localPosition = startPosition + new Vector3(x, 0, 0);
    }
}
