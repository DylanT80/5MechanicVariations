using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode jumpKey;

    public float speed = 10f;

    void Update()
    {
        Vector3 pos = transform.position;

        // "w" can be replaced with any key
        // this section moves the character up
        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }

        // "s" can be replaced with any key
        // this section moves the character down
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }

        // "d" can be replaced with any key
        // this section moves the character right
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }

        // "a" can be replaced with any key
        // this section moves the character left
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        
        // "shift" can be replaced with any key
        // this section makes the speed 2 times fast acting as a sprint mechanic
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            speed = speed * 2;
        }
        
        if (Input.GetKeyUp(KeyCode.LeftShift)) {
            speed = speed / 2;
        }

        transform.position = pos;
    }
}
