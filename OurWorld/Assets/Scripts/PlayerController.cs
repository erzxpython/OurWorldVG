using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = .01f;
    public bool hasKey = false;

    public GameObject key;

    
    public static PlayerController instance; //creating an object of the class to be findable

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null) //check if instance is in the scene
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        GameObject.DontDestroyOnLoad(gameObject);
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("key"))
        {
            Debug.Log("obtained key");
            key.SetActive(false);//key disappears
            hasKey = true;//the key now
        }

        //write code for exiting second scene and go back to first scene
        if (collision.gameObject.tag.Equals("exit"))
        {
            Debug.Log("hit");
            SceneManager.LoadScene(0);
        }
    }
}