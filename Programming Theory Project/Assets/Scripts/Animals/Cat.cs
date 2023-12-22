using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{

    //POLYMORPHISM -COURSE-.
    protected override void Awake()
    {
        base.Awake();
        minAnimalTemperature = 15;
        minHeatRange = 30;
        interestPoint = GameObject.Find("CatInterestPoint").transform;
    }

}
