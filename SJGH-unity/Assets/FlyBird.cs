using UnityEngine;

public class FlyBird : MonoBehaviour
{

    public int jumpPower = 8;
    public int gravity = -6;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 position = transform.position;
            position.y += jumpPower;
            transform.position = position;
        }
    }
}
