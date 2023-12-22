using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // POLYMORPHISM -COURSE-.
    protected override void Awake()
    {
        base.Awake();
        interestPoint = GameObject.Find("DogInterestPoint").transform;
    }

}
