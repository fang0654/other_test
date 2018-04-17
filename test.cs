using System;
 using System.Configuration.Install;
 using System.Runtime.InteropServices;
 using System.Management.Automation.Runspaces;
 
 public class Program
 {
    public static void Main(String[] args)
    {
        string command = String.Join(" ", args);
        MyTestcode.Exec(command);
    }
 }
 
 
 public class MyTestcode
 {
 public static void Exec(string command)
 {
 
 RunspaceConfiguration rspacecfg = RunspaceConfiguration.Create();
 Runspace rspace = RunspaceFactory.CreateRunspace(rspacecfg);
 rspace.Open();
 Pipeline pipeline = rspace.CreatePipeline();
 pipeline.Commands.AddScript(command);
 pipeline.Invoke();
 }
 }
