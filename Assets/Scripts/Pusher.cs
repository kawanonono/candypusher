using UnityEngine;

public class PusherMove : MonoBehaviour
{
    //public=�A�N�Z�X�C���q float=float��p�ƒ�`����@
    //float=�����_�@int=����only�@speed=�ϐ��� ;=�����܂ł̕��𖽗߂Ƃ��Ē�`
    public float speed = 1.0f;
    public float pusherMoveRenge = 5.0f;
    private Vector3 startPosition;
    private Rigidbody rb;


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
        // ���g�̃��[�J�����W�̈ʒu���@�ŏ��̈ʒu���W�Ɂ@���iSin�g�̕ϓ��l�j�����Z���ĕԂ�
        this.transform.localPosition = startPosition + new Vector3(0, 0, z);
        //rb.linearVelocity = new Vector3(0,0,z);
    }
}
