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
    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    public static void mkdir(string path) => Directory.CreateDirectory(path);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    public static void Remove(string path) => File.Delete(path);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    public static void listdir(string path) => Directory.GetFileSystemEntries(path);
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static string getcwd() => Environment.CurrentDirectory;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    public static void chdir(string path) => Environment.CurrentDirectory = path;
}