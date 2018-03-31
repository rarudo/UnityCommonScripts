using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class ListExtention{
    /// <summary>
    /// リストの最後からgetAmount個取得するメソッド
    /// Based From http://harhogefoo.xyz/blog/2016/08/12/clistの末尾の要素を取得する拡張メソッドを作って/
    /// </summary>
    /// <param name="self"></param>
    /// <param name="getAmount"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> GetFromLast<T>(this List<T> self, int getAmount)
    {
        int startIndex;
        if (self.Capacity < getAmount)
        {
            startIndex = 0;
        }
        else
        {
            startIndex = self.Count - getAmount;
        }
        return self.GetRange(startIndex, getAmount);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="self"></param>
    /// <param name="getAmount"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> GetRandomPick<T>(this List<T> self, int getAmount)
    {
        int count = self.Count;
        if (count < getAmount)
        {
            getAmount = count;
        }
        //TODO このままだとPickする値が重複する可能性がある
        int[] pickIndex = new int[getAmount];
        for (int i = 0; i < pickIndex.Length; i++)
        {
            pickIndex[i] = Random.Range(0, getAmount);
        }
        List<T> returnList = new List<T>();
        foreach (var index in pickIndex)
        {
            returnList.Add(self[index]);
        }
        return returnList;
    }
}
