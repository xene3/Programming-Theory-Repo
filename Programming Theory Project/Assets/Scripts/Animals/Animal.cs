using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Animal : MonoBehaviour
{
    private NavMeshAgent navMeshAgent; //Agent

    protected Transform interestPoint;

    private AnimalNavController animalNavController; //FOR ALL POSITIONS

    [SerializeField] protected float animalTemperature;

    //ENCAPSULATION -COURSE-.
    private float m_minAnimalTemperature;
    public float minAnimalTemperature
    {
        get
        {
            return m_minAnimalTemperature;
        }

        set
        {
            if(value < 0.0f)
            {
                Debug.LogError("Minimal animal temperature can't be less than 0 C°!");
            }
        }
    }
    [SerializeField] protected float minHeatRange;
    [SerializeField] protected float maxHeatRange;

    [SerializeField] int shadowLocation; 

    [SerializeField] bool isInShadow; //ToLowTemperature

    protected virtual void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animalNavController = GameObject.Find("IA Positions").GetComponent<AnimalNavController>();

        m_minAnimalTemperature = 20;
        animalTemperature = minAnimalTemperature;
        minHeatRange = 35;
        maxHeatRange = 40;
    }

    private void Start()
    {
       shadowLocation = Random.Range(0, animalNavController.shadowPositions.Count);
    }

    // Update is called once per frame
    void Update()
    {
        //ABSTRACTION -COURSE-.
        AnimalNeeds();
    }

    
    protected virtual void AnimalNeeds()
    {
        //SHADOW AND HEAT CONTROLL OF THE ANIMAL.
        if (!isInShadow)
        {
            animalTemperature += Time.deltaTime;

            if(animalTemperature < minHeatRange)
            {
                MoveTowardsInterestPoint();
            }

            if (animalTemperature >= Random.Range(minHeatRange, maxHeatRange))
            {
                MoveTowardsShadow();
            }
        }
        else if(isInShadow && animalTemperature > minAnimalTemperature)
        {
            animalTemperature -= Time.deltaTime;

            if (animalTemperature <= minAnimalTemperature)
            {
                MoveTowardsInterestPoint();
            }
        }
    }

    protected virtual void MoveTowardsInterestPoint()
    {
        navMeshAgent.destination = interestPoint.position;
        isInShadow = false;
    }

    protected virtual void MoveTowardsShadow()
    {

        navMeshAgent.destination = animalNavController.shadowPositions[shadowLocation].position;

        if (Vector3.Distance(transform.position, navMeshAgent.destination) <= 1)
        {
            isInShadow = true;
        }
    }

}
