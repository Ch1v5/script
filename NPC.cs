using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int lives = 1;
    public int level = 1;

    public Vector3 newPosition;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        //lives will be equal to the value of lives (1) + level (1)
        lives = lives + level;
        print(lives);
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;

        newPosition.x += speed * Time.deltaTime;

        transform.position = newPosition;
    }
}



