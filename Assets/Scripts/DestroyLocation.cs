using System;
using UnityEngine;

public class DestroyLocation : CardLocation
{
    public override event Action OnEnd;

    public DestroyLocation(GameObject gameObject) 
    {
        _gameObject = gameObject;
        OnEnd = () => GameObject.Destroy(_gameObject);
    }

    public override CardLocation Next()
    {
        Debug.Log("end");
        return null;
    }
}