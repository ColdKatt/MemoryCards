using System;
using UnityEngine;

public class InitializeLocation : CardLocation
{
    public override event Action OnEnd;

    public InitializeLocation(GameObject gameObject)
    {
        _gameObject = gameObject;
    }

    public override CardLocation Next()
    {
        return new MainLocation(_gameObject);
    }
}
