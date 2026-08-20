using UnityEngine;

public class PuserController : MonoBehaviour
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
    private float targetZ;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
        targetZ = startPosition.z;
    }

    // Update is called once per frame
    void Update()
    {
        // PCでのテスト用
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 position = transform.position;

        position.x += horizontal * moveSpeed * Time.deltaTime;

        // 左右の移動範囲を制限
        position.x = Mathf.Clamp(position.x, minX, maxX);

        // 前進中でなければ左右操作可能
        if (!isPushing)
        {
            transform.position = position;
        }

        // 前進処理
        if (isPushing)
        {
            float newZ = Mathf.MoveTowards(
                transform.position.z,
                targetZ,
                pushSpeed * Time.deltaTime
            );

            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                newZ
            );

            // 前進が終了したら元の位置へ戻す
            if (Mathf.Abs(transform.position.z - targetZ) < 0.01f)
            {
                isPushing = false;
                targetZ = startPosition.z;
            }
        }
    }

    // 「おす！」ボタンから呼び出す
    public void Push()
    {
        if (isPushing)
            return;

        targetZ = startPosition.z + pushDistance;
        isPushing = true;
    }
}
