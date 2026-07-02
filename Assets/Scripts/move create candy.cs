using UnityEngine;

public class MoveCreatePosition : MonoBehaviour
{
    private Vector3 startPosition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //sin”g‚Ì“®‚«
        float x = Mathf.Sin(Time.time * 1f)*3f;
        //Sin”g‚Ì“®‚«‚ðxŽ²‚É”½‰f‚³‚¹‚é
        this.transform.position = startPosition + new Vector3(x, 0, 0);
    }
}