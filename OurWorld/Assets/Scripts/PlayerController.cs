using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = .01f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //create a variable that holds value of position (position will always be a Vector value!)
        Vector3 newPosition = transform.position;

        //press KeyCode.UpArrow key to move up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            newPosition.y += speed; //same as newPosition.y = newPosition.y + speed
        }

        //press  KeyCode.DownArrow key to move down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            newPosition.y -= speed;
        }

        //press KeyCode.LeftArrow key to move left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition.x -= speed;
        }

        //press KeyCode.RightArrow key to move right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            newPosition.x += speed;
        }

        //update the current position to the new position
        transform.position = newPosition;
    }
}