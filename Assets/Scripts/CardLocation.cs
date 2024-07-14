using System;
using UnityEngine;

public abstract class CardLocation
{
    public abstract event Action OnEnd;

    protected GameObject _gameObject;

    protected Vector3 _position;
    public abstract CardLocation Next();

    public virtual void Move()
    {
        // DOTWEEN MOVING
    }
}
