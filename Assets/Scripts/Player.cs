using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 15f;
    private float moveX;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }

    void playerMovement()
    {
        moveX = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        Vector3 temp = transform.position + Vector3.right * moveX;
        temp.x = Mathf.Clamp(temp.x, -7f, 7f);
        transform.position=temp;
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<GameManager>().endGame();
    }
}
