using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal //INHERITANCE
{
    // POLYMORPHISM -COURSE-.
    protected override void InitialParameters()
    {
        base.InitialParameters();
        interestPoint = GameObject.Find("DogInterestPoint").transform;
    }

}
