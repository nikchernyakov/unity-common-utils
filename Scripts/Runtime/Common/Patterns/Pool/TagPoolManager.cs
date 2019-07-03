using UnityEngine;

public class TagPoolManager<P, T> : Singleton<P> where P : TagPoolManager<P, T> { 
    
    //public Pool _Pool { get; private set; }

    private void Awake()
    {
        //_Pool = InitPool(TagEnum._Pool);
    }

    protected Pool InitPool(T tagEnum)
    {
        var pool = GameObject             
            .FindGameObjectWithTag(TagUtils.GetTagNameByEnum(tagEnum))
            .GetComponent<Pool>();
        pool.Init();
        return pool;
    }
}
