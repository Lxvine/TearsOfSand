using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    [SerializeField] private Transform[] movePoints;

    [SerializeField] private float minDistance;

    private int randomNumber;

    private SpriteRenderer enemySR;

    private void Start(){
        randomNumber = Random.Range(0, movePoints.Length);
        enemySR = GetComponent<SpriteRenderer>();
        Turn();
    }

    private void Update(){
        transform.position = Vector2.MoveTowards(transform.position, movePoints[randomNumber].position, moveSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, movePoints[randomNumber].position) < minDistance)
        {
            randomNumber = Random.Range(0, movePoints.Length);
            Turn();
        }
    }

    private void Turn(){
        if (transform.position.x < movePoints[randomNumber].position.x)
        {
            enemySR.flipX = true;
        } else{
            enemySR.flipX = false;
        }
    }

}
