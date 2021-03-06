using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighningEnemy : Enemy
{
    private float FDam = 15, WDam = 15, EDam = 30, LDam = 20;

    public override void movement()
    {
        throw new System.NotImplementedException();
        //Move forward by one unit after every collsion sequence is completed
    }

    // Start is called before the first frame update
    void Start()
    {
        health = base.health;
        //base.health;
        Debug.Log("Health of Lightning Enemy is " + health);
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
            this.health -= WDam;
            Debug.Log("Damaged by Waterball inside the function, new health is " + health);
        }
        else if (ball.GetType() == typeof(EarthBall))
        {
            this.health -= EDam;
            
            Debug.Log("Damaged by EarthBall inside the function, new health is " + health);
        }

        else if (ball.GetType() == typeof(LightningBall))
        {
            //this.health -= LDam;
            this.health = (this.health + LDam > 100) ? 100 : this.health += LDam;
            Debug.Log("Damaged inside the function, new health is " + health);
        }
        else
        {
            Debug.Log(" Puny weapon, HaHaAAHhaha");
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
    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Health is" + health);
        
    }
}
