using System.Collections;
using UnityEngine;
using System;

public static class Timer
{
    public static IEnumerator Start(float maxTime, Action action)
    {
        float elapsedTime = 0;

        while (elapsedTime <= maxTime)
        {
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        action.Invoke();
    }
}
