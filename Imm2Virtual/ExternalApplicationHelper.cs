using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imm2Virtual
{
    internal static class ExternalApplicationHelper
    {
        internal static string LaunchExternalApplication(string applicationPath, string applicationParameters)
        {
            using (System.Diagnostics.Process pProcess = new System.Diagnostics.Process())
            {
                pProcess.StartInfo.FileName = applicationPath;
                pProcess.StartInfo.Arguments = applicationParameters;
                pProcess.StartInfo.UseShellExecute = false;
                pProcess.StartInfo.RedirectStandardOutput = true;
                pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                pProcess.StartInfo.CreateNoWindow = true;
                pProcess.Start();
                string output = pProcess.StandardOutput.ReadToEnd();
                pProcess.WaitForExit();
                return output;

            }



        }
    }
}
