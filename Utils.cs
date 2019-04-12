using System.IO;
using System.Diagnostics;

public class Utils
{
    public static Process Run(string bin, params string[] args)
    {
        var psi = new ProcessStartInfo();
        psi.FileName = bin;
        psi.RedirectStandardOutput = true;
        psi.RedirectStandardError = true;

        /* add process arguments */
        foreach (var arg in args)
        {
            psi.ArgumentList.Add(arg);
        }

        var proc = new Process();
        proc.StartInfo = psi;

        proc.Start();

        return proc;
    }

    /*
     * do 'rm -rf <DirPath>'
     */
    public static void RemoveDir(string DirPath)
    {
        if (!Directory.Exists(DirPath))
        {
            /* does not exist, don't try to remove or we'll get an exception */
            return;
        }
        Directory.Delete(DirPath, true);
    }
}