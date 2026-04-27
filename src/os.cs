#pragma warning disable CS8981

using System.Text;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace PySharp;

/// <summary>
/// Provides a way of using operating system dependent functionality.
/// </summary>
public static class os
{
    /// <summary>
    /// Common pathname manipulations.
    /// </summary>
    public static class path
    {
        /// <summary>
        /// Returns true if path refers to an existing path or an open file descriptor.
        /// </summary>
        /// <param name="path">The path to check.</param>
        /// <returns>True if the directory or file exists; otherwise, false.</returns>
        public static bool exists(string path)
        {
            if (Directory.Exists(path) || File.Exists(path))
                return true;
            return false;
        }
        /// <summary>
        /// Join one or more path components intelligently.
        /// </summary>
        /// <param name="parts">Path components to join.</param>
        /// <returns>The concatenated path string.</returns>
        public static string join(params string[] parts) => Path.Combine(parts);
        /// <summary>
        /// Return the size, in bytes, of path.
        /// </summary>
        /// <param name="p">The path to the file.</param>
        /// <returns>The size of the file in bytes.</returns>
        /// <exception cref="FileNotFoundException">Thrown when the file does not exist.</exception>
        public static long getsize(string p) => new FileInfo(p).Length;
        /// <summary>
        /// Return a normalized absolutized version of the pathname path.
        /// </summary>
        /// <param name="p">The path to convert.</param>
        /// <returns>The absolute path.</returns>
        public static string abspath(string p) => Path.GetFullPath(p);
    }

    /// <summary>
    /// Create a directory named path with numeric mode.
    /// </summary>
    /// <param name="path">The directory path to create.</param>
    public static void mkdir(string path) => Directory.CreateDirectory(path);
    /// <summary>
    /// Remove (delete) the file path.
    /// </summary>
    /// <param name="path">The file path to remove.</param>
    public static void remove(string path) => File.Delete(path);
    /// <summary>
    /// Returns a list containing the names of the entries in the directory given by path.
    /// </summary>
    /// <param name="path">The directory path to list.</param>
    /// <returns>An array of strings containing the names of the entries in the directory.</returns>
    public static string[] listdir(string path) => new DirectoryInfo(path).GetFileSystemInfos().Select(f => f.Name).ToArray();
    /// <summary>
    /// Returns a string representing the current working directory.
    /// </summary>
    /// <returns>The current working directory.</returns>
    public static string getcwd() => Environment.CurrentDirectory;
    /// <summary>
    /// Change the current working directory to path.
    /// </summary>
    /// <param name="path">The new working directory path.</param>
    public static void chdir(string path) => Environment.CurrentDirectory = path;
    /// <summary>
    /// The name of the operating system dependent module imported.
    /// Returns 'nt' for Windows and 'posix' for other platforms.
    /// </summary>
    /// <returns>A string representing the OS type.</returns>
    public static string name()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return "nt";
        return "posix";
    }
    /// <summary>
    /// Return the value of the environment variable name if it exists, or an empty string if it doesn't.
    /// </summary>
    /// <param name="name">The name of the environment variable.</param>
    /// <returns>The value of the environment variable.</returns>
    public static string getenv(string? name)
    {
        return Environment.GetEnvironmentVariable(name ?? "") ?? "";
    }
}