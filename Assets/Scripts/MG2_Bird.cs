using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MG2_Bird : MonoBehaviour
{
    [SerializeField]private Rigidbody2D _rigidbody;
    [SerializeField]private MG2_Player_Manager _playerManager;
    private bool isJumping = false;
    // Start is called before the first frame update
    private void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            isJumping = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            _playerManager._addScore(1);
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, 5f);
            isJumping = true;
        }

    }
}
