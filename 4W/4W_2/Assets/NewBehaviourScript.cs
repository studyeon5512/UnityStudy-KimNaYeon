using System.Collections;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Coroutine myCoroutine1;
    private IEnumerator myCoroutine2;

    void Start()
    {
        myCoroutine1 = StartCoroutine(LoopA());
        myCoroutine2 = LoopC();
        StartCoroutine(myCoroutine2);
        StartCoroutine("LoopB");
        StartCoroutine(Stoooop());
    }

    #region Loop
    IEnumerator LoopA()
    {
        for (int i = 0; i < 100; i++)
        {
            print("x의 값 : " + i);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator LoopB()
    {
        for (int i = 0; i < 100; i++)
        {
            print("i의 값 : " + i);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator LoopC()
    {
        for (int i = 0; i < 100; i++)
        {
            print("y의 값 : " + i);
            yield return new WaitForSeconds(1f);
        }
    }
    #endregion Loop

    IEnumerator Stoooop()
    {
        yield return new WaitForSeconds(2f);
        StopCoroutine(myCoroutine1);
        StopCoroutine("LoopB");
        StopCoroutine(myCoroutine2);
        yield return new WaitForSeconds(2f);
        StopAllCoroutines();
    }
}
