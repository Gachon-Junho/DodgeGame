using System.Collections;
using UnityEngine;

public abstract class ObjectGenerator : MonoBehaviour
{
    [SerializeField] 
    public GameObject TargetPrefab;
    
    public bool IsGenerating { get; private set; }
    
    public (float start, float end) XRange;
    public (float start, float end) YRange;
    public (float start, float end) ZRange;

    public (float start, float end) CreateTimeIntervalRange;

    public void Generate()
    {
        StartCoroutine(CreateObject());
        IsGenerating = true;
    }

    public void Stop() => IsGenerating = false;

    protected IEnumerator CreateObject()
    {
        yield return new WaitForSeconds(Random.Range(CreateTimeIntervalRange.start, CreateTimeIntervalRange.end));

        var obj = Instantiate(TargetPrefab);
        obj.transform.position = new Vector3(
            Random.Range(XRange.start, XRange.end),
            Random.Range(YRange.start, YRange.end), 
            Random.Range(ZRange.start, ZRange.end));

        if (IsGenerating)
            StartCoroutine(CreateObject());
    }
}
