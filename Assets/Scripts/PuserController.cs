using UnityEngine;

public class PusherController : MonoBehaviour
{
    [Header("左右移動")]
    [SerializeField] private float minX = -2.5f;
    [SerializeField] private float maxX = 2.5f;
    [SerializeField] private float moveSpeed = 5f;

    [Header("前進")]
    [SerializeField] private float pushDistance = 1.2f;
    [SerializeField] private float pushSpeed = 3f;

    private Vector3 startPosition;

    private bool isPushing = false;
    private bool isReturning = false;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // =========================
        // 左右移動
        // =========================

        if (!isPushing && !isReturning)
        {
            float horizontal = Input.GetAxis("Horizontal");

            Vector3 position = transform.position;

            position.x += horizontal * moveSpeed * Time.deltaTime;

            position.x = Mathf.Clamp(
                position.x,
                minX,
                maxX
            );

            transform.position = position;
        }

        // =========================
        // 前進
        // =========================

        if (isPushing)
        {
            float targetZ = startPosition.z + pushDistance;

            Vector3 position = transform.position;

            position.z = Mathf.MoveTowards(
                position.z,
                targetZ,
                pushSpeed * Time.deltaTime
            );

            transform.position = position;

            // 前進終了
            if (Mathf.Abs(position.z - targetZ) < 0.01f)
            {
                isPushing = false;
                isReturning = true;
            }
        }

        // =========================
        // 元の位置に戻る
        // =========================

        if (isReturning)
        {
            Vector3 position = transform.position;

            position.z = Mathf.MoveTowards(
                position.z,
                startPosition.z,
                pushSpeed * Time.deltaTime
            );

            transform.position = position;

            // 戻る処理終了
            if (Mathf.Abs(position.z - startPosition.z) < 0.01f)
            {
                position.z = startPosition.z;

                transform.position = position;

                isReturning = false;
            }
        }
    }

    // =========================
    // 「おす！」ボタン
    // =========================

    public void Push()
    {
        if (isPushing || isReturning)
            return;

        isPushing = true;

        Debug.Log("プッシャーを押しました！");
    }
}