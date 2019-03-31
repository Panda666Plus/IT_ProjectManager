using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace clsReadWriteInI
{
  public   class NativeApiHelper
    {
      [DllImport("Kernel32.dll", CharSet = CharSet.Unicode)]
      public static extern int CreateMutex(IntPtr lpMutexAttributes, bool bInitialOwner, string lpName); 
         [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
         public static extern int  GetLastError();

    }
}
