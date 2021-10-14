using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEnemy : Enemy
{
    private float FDam = 20, WDam = 30, EDam = 15, LDam = 15;
    public override void movement()
    {
        throw new System.NotImplementedException();
    }
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(PowerBall ball)
    {


        /*if(ball == base.ball1)
        {
            Debug.Log("Take Damage on" + this.name +ball.name);
        }*/
        Debug.Log("Take Damage on " + this.name + " " + ball);


        if (ball.GetType() == typeof(FireBall))
        {
            this.health -= FDam;
            
            Debug.Log("Damaged by Fireball inside the function, new health is " + health);
        }

        else if (ball.GetType() == typeof(WaterBall))
        {
            this.health += WDam;
            this.health = (this.health + WDam > 100) ? 100 : this.health += WDam;
            Debug.Log("Damaged by Waterball inside the function, new health is " + health);
        }
        else if (ball.GetType() == typeof(EarthBall))
        {
            this.health -= EDam;
            Debug.Log("Damaged by EarthBall inside the function, new health is " + health);
        }

        else if (ball.GetType() == typeof(LightningBall))
        {
            this.health -= LDam;
            Debug.Log("Damaged inside the function, new health is " + health);
        }
        else
        {
            Debug.Log(" No Damage");
        }

    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("We have hit something");

        if (collisionInfo.gameObject.GetComponent<PowerBall>() != null)
        {
            TakeDamage(collisionInfo.rigidbody.GetComponent<PowerBall>());
        }
    }
        /* TAG COLLIDER - uses up too much memory
         * private void OnCollisionEnter(Collision collisionInfo)
        {
            Debug.Log("We have hit" + collisionInfo.rigidbody.tag);

            string colliderType = collisionInfo.rigidbody.tag;

            if (colliderType == "WaterB")
            {
                //Pass both Enemy name and Collider name as arguments to a
                //script somewhere and have a dictionary figure out the damage?
                //Also health cannot go beyond 100
                Debug.Log("Health!!! +20");
                health += 30;
                Debug.Log(health);

            }
            else if (colliderType == "FireB")
            {
                Debug.Log("Damage -20");
                health -= 20;
                Debug.Log(health);
            }
            else if (colliderType == "EarthB")
            {
                Debug.Log("Damage -15");
                health -= 20;
                Debug.Log(health);
            }
            else if (colliderType == "LightB")
            {
                Debug.Log("Damage -15");
                health -= 15;
                Debug.Log(health);
            }
            else
            {
                Debug.Log("Damage Null");
            }
        }*/
    }
