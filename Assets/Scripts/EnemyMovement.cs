using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float enemySpeed;
    Rigidbody2D _rigid;
    BoxCollider2D _boxCollider;

    void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _boxCollider = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        _rigid.velocity = new Vector2 (enemySpeed * Time.deltaTime, 0f);
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        enemySpeed = -enemySpeed;
        FlipEnemyFacing();
    }
    void FlipEnemyFacing()
    {

    transform.localScale = 
            new Vector2 (-(Mathf.Sign(_rigid.velocity.x)), 1f);
 
    }
}
