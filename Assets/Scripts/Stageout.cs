using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class StageOut : MonoBehaviour
{
    private int Score = 0;
    public TextMeshProUGUI scoreText;

    // このコードをアタッチしたオブジェクトに他のオブジェクトがすり抜けた時に呼ばれる
    public AudioManager audioManager;
    void OnTriggerEnter(Collider other)
    //　アクセス修飾子　型　変数名　；
    {
        audioManager.SEPlay();
        Score += 1;

    //変数scoreTxstのtxstプロパティ（文字を表示する機能）に
    //スコア:｛Score｝を代入（表示）する
    scoreText.text = $"スコア:{Score}";
    // Debug.Log($"{other.name}がすり抜けた");
    // すり抜けたオブジェクトを破壊
    Destroy(other.gameObject);
    }
}
