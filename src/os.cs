#pragma warning disable CS8981

using System.Text;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace PySharp;

/// <summary>
/// 
/// </summary>
public static class os
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static bool exists(string path)
    {
        if (Directory.Exists(path) || File.Exists(path))
            return true;
        return false;
    }
}