using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public abstract void movement();
    [SerializeField] protected float health=100;
    // Start is called before the first frame update

    public PowerBall ball1;

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
