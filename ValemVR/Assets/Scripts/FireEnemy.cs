using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemy : Enemy
{
    private float FDam = 30, WDam = 20, EDam = 15, LDam =15;
    public BoxCollider fBoxCollider;

    
    public override void movement()
    {
        throw new System.NotImplementedException();
        //Move forward by one unit after every step
    }

    // Start is called before the first frame update
    void Start()
    {
        
        health = base.health;
        //base.health;
        Debug.Log("Health of Fire Enemy is" + health);
        fBoxCollider = gameObject.GetComponent<BoxCollider>();
      
    }

    private void Update()
    {
        //Debug.Log("Health is" + health);
        //fBoxCollider.
        /* if (GameObject.GetComponent<Collider> == PowerBall.GetComponent<Collider>)
         if(this.GetComponent<Collider> == PowerBall.GetComponent<Collider>)
             {

             }*/
        Debug.Log(ball1.base)
    }


    // Update is called once per frame
    public void TakeDamage(PowerBall ball)
    {
      
        
        /*if(ball == base.ball1)
        {
            Debug.Log("Take Damage on" + this.name +ball.name);
        }*/
        Debug.Log("Take Damage on " + this.name + " " + ball);


        if (ball.GetType() == typeof(FireBall))
        {
            this.health += FDam;
            this.health = (this.health+ FDam > 100) ? 100 : this.health += FDam;
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
        foreach (ContactPoint contact in collisionInfo.contacts)
        {
            Debug.Log(contact.otherCollider);
            if(contact.otherCollider.Equals(ball1.GetComponent<SphereCollider>()))
            {
                Debug.Log("We have made contact with a ball");
            }        
        }

        //collisionInfo.contacts.
        Debug.Log("We have hit something "+ collisionInfo.collider.gameObject);


/*        if (collisionInfo.rigidbody == collisionInfo.rigidbody.GetComponent<PowerBall>())
        {
            TakeDamage(collisionInfo.rigidbody.GetComponent<PowerBall>());
        }*/


        //(this.gameObject.collide)
        //Debug.Log("We have hit" + collisionInfo.rigidbody.GetComponent<PowerBall>());
        //if( this.GetComponent<BoxCollider>().)

        /*       Doesnt work. The entire block gets skipped. Doesn't get called on Collision
         *       if (collisionInfo.GetType() == typeof(PowerBall)) //comparing the class of the collisionInfo with Powerball over here.wrong approach
                {
                    TakeDamage(collisionInfo.rigidbody.GetComponent<PowerBall>());
                }*/

        //Works.
        if (collisionInfo.gameObject.GetComponent<PowerBall>() != null)
        {
            TakeDamage(collisionInfo.rigidbody.GetComponent<PowerBall>());
        }
        ////base.ball1.gameObject.GetComponent<PowerBall>

        /* Second approach, use if statements to check tag of colliding object.
         string colliderType = collisionInfo.rigidbody.tag;

        /*        if (colliderType == "FireB")
                {
                    //Pass both Enemy name and Collider name as arguments to a
                    //script somewhere and have a dictionary figure out the damage?
                    //Also health cannot go beyond 100
                    Debug.Log("Health!!! +30");
                    health += 30;
                    Debug.Log(health);

                }
                 if (colliderType == "WaterB")
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
        */
    }


}
