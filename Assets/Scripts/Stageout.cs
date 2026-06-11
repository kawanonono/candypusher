using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Steadeout : MonoBehaviour
{
    private int Score;

    // このコードをアタッチしたオブジェクトに他のオブジェクトがすり抜けた時に呼ばれる
    void OnTriggerEnter(Collider other)
    //　アクセス修飾子　型　変数名　；
    {
    Score = Score + 1;
    Debug.Log($"スコア:{Score}");
    // Debug.Log($"{other.name}がすり抜けた");
    // すり抜けたオブジェクトを破壊
    Destroy(other.gameObject);
    }
}
