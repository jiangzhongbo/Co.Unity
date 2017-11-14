using UnityEngine;
using System.Collections;
public class testco2 : MonoBehaviour
{
    void Start()
    {
        var co = gameObject.AddComponent<Co>();
        co.Run(test1());
    }


    IEnumerator test1()
    {
        Debug.Log(1);
        yield return test2();
        Debug.Log(4);
    }

    IEnumerator test2()
    {
        Debug.Log(2);
        yield return null;
        Debug.Log(3);
    }

    IEnumerator test3()
    {
        //yield return UPromise.Promise.Resolve(0);
        yield return Co.ToNext;
        yield return Co.ToUpdate;
        yield return Co.ToFixedUpdate;
        yield return Co.ToLateUpdate;
    }
}
