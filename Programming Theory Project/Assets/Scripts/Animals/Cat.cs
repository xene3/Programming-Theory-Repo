using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal //INHERITANCE
{

    //POLYMORPHISM -COURSE-.
    protected override void InitialParameters()
    {
        base.InitialParameters();
        minAnimalTemperature = 15;
        minHeatRange = 30;
        interestPoint = GameObject.Find("CatInterestPoint").transform;
    }

}
