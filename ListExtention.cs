using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
