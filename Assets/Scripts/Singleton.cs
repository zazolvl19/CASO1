using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour
    where T : Component
{
    static Singleton<T> _instance;

    protected static object _Lock = new object();

    protected virtual void Awake()
    {
        bool destroyMe = true;

        if( _instance == null )
        {
            lock ( _Lock )
            {
                if(_instance == null ) 
                { 
                    destroyMe = false;
                    _instance = this;

                    DontDestroyOnLoad(gameObject);
                }
            }
        }
        if( destroyMe )
        {
            Destroy(gameObject);
            return;

        }
    }

    public static T Instance
    {
        get
        {
            return _instance as T;
        }
    }
}
