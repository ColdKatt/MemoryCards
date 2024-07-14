using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLocation : CardLocation
{
    public override event Action OnEnd;

    public MainLocation(GameObject gameObject)
    {
        _gameObject = gameObject;
    }

    public override CardLocation Next()
    {
        return new DestroyLocation(_gameObject);
    }
}
