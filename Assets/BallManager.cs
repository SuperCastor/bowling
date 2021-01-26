using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Ball;
    public Rigidbody ballBody;
    private bool launched = false;
    public float strenght;
    private Vector3 startPos;

    void Start()
    {
        startPos = Ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            launched = true;
            ballBody.freezeRotation = false;
        if (Input.GetKeyDown(KeyCode.LeftArrow) && launched == false)
            Ball.transform.position = new Vector3(Ball.transform.position.x - 1, Ball.transform.position.y, Ball.transform.position.z);
        if (Input.GetKeyDown(KeyCode.RightArrow) && launched == false)
            Ball.transform.position = new Vector3(Ball.transform.position.x + 1, Ball.transform.position.y, Ball.transform.position.z);
        if (launched == true)
            Ball.transform.Translate(Vector3.forward * Time.deltaTime * strenght);
        if (Ball.transform.position.y < -2) {
            launched = false;
            ballBody.velocity = Vector3.zero;
            ballBody.freezeRotation = true;
            Ball.transform.rotation = Quaternion.identity;
            Ball.transform.position = startPos;
        }
    }
}
