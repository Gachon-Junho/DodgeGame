using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : ObjectGenerator
{
    public const float LEVEL_SIZE = 20.5f;

    public ObstacleGenerator()
    {
        XRange = (-LEVEL_SIZE, LEVEL_SIZE);
        YRange = (40, 40);
        ZRange = (-LEVEL_SIZE, LEVEL_SIZE);

        CreateTimeIntervalRange = (0.5f, 1.5f);
    }
    
    [SerializeField]
    private float createTimeInvervalStart;
    
    [SerializeField] 
    private float createTimeInvervalEnd;
    
    // Start is called before the first frame update
    void Start()
    {
        Generate();
    }

    private IEnumerator CreateObstacle()
    {
        yield return new WaitForSeconds(Random.Range(createTimeInvervalStart, createTimeInvervalEnd));

        var obstacle = Instantiate(TargetPrefab);
        obstacle.transform.position = new Vector3(Random.Range(-LEVEL_SIZE, LEVEL_SIZE), 
            obstacle.transform.position.y,
            Random.Range(-LEVEL_SIZE, LEVEL_SIZE));
    }
}
