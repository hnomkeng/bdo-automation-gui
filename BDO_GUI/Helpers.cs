using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Automation;

namespace BDO_GUI
{
    public class Helpers
    {
        public class User32
        {
            [DllImport("user32.dll")]
            public static extern bool SetForegroundWindow(IntPtr hWnd);
        }

        public static Tuple<IntPtr, string> FindApplication(string name)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (process.MainWindowTitle.ToLower().IndexOf(name.ToLower(), StringComparison.InvariantCulture) > -1)
                {
                    return new Tuple<IntPtr, string>(process.MainWindowHandle, process.MainWindowTitle);
                }
            }

            return new Tuple<IntPtr, string>(IntPtr.Zero, string.Empty);
        }
    }

    public static class AutomationElementHelpers
    {
        public static AutomationElement Find(this AutomationElement root, string name)
        {
            return root.FindFirst(
             TreeScope.Descendants,
             new PropertyCondition(AutomationElement.NameProperty, name));
        }

        public static IEnumerable<AutomationElement> EnumChildButtons(this AutomationElement parent)
        {
            return parent == null ? Enumerable.Empty<AutomationElement>()
                                  : parent.FindAll(TreeScope.Children,
              new PropertyCondition(AutomationElement.ControlTypeProperty,
                                    ControlType.Button)).Cast<AutomationElement>();
        }

        public static bool InvokeButton(this AutomationElement button)
        {
            var invokePattern = button.GetCurrentPattern(InvokePattern.Pattern)
                               as InvokePattern;
            if (invokePattern != null)
            {
                invokePattern.Invoke();
            }
            return invokePattern != null;
        }
    }
}
