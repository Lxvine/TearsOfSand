using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public PlayerController playerController;
    Animator animator;
    public float health = 3;

    public int damage = 1;

    bool isAlive = true;
    [SerializeField]
    private float pointsQuantity = 100;

    [SerializeField]
    private NumberPoints points;

    
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Player")
        {
            playerController.TakeDamage(damage);           
        }
    }
    public float Health
    {
        set
        {
            if (value < health)
            {
                Hit();
            }

            health = value;

            if (health <= 0)
            {
                Defeated();
            }
        }
        get { return health; }
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isAlive", isAlive);
        points = GameObject.Find("Points").GetComponent<NumberPoints>();
    }

    public void Hit()
    {
        animator.SetTrigger("Hit");
    }

    public void Defeated()
    {
        animator.SetBool("isAlive", false);
    }

    public void RemoveEnemy()
    {
        points.IncreasePoints(pointsQuantity);
        Destroy(gameObject);
    }

}
