using UnityEngine;

public class PusherMove : MonoBehaviour
{
    //public=アクセス修飾子 float=float専用と定義する　
    //float=小数点　int=整数only　speed=変数名 ;=ここまでの文を命令として定義
    public float speed = 1.0f;
    public float pusherMoveRenge = 5.0f;
    private Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World");
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float z = Mathf.Sin(Time.time * speed) * pusherMoveRenge;
        // 自身のローカル座標の位置を　最初の位置座標に　ｚ（Sin波の変動値）を加算して返す
        this.transform.localPosition = startPosition + new Vector3(0, 0, z);
    }
}

