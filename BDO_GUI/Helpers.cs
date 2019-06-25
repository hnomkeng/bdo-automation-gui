using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

        public static  string GetWorkingDirectory()
        {
            string workingDirectory = "C:/Users/Duc Truong/Downloads/bdo/";
            if (Directory.Exists(workingDirectory))
            {
                return workingDirectory;
            }

            return Directory.GetCurrentDirectory();
        }
    }

    public static class StringHelpers
    {
        public static string GetDisplayName(this string input)
        {
            input = input.Split('/').Last().Replace("_highlighted", string.Empty).Replace(".png", string.Empty).Replace("_", " ");
            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }

    public static class AutomationElementHelpers
    {
        public static void InvokeButtonByName(Func<string, bool> func)
        {
            IEnumerable<AutomationElement> icons = AutomationElementHelpers.EnumNotificationIcons();
            foreach (AutomationElement icon in icons)
            {
                string name = icon.GetCurrentPropertyValue(AutomationElement.NameProperty) as string;
                if (func(name))
                {
                    icon.InvokeButton();
                    break;
                }
            }
        }

        public static IEnumerable<AutomationElement> EnumNotificationIcons()
        {
            foreach (AutomationElement button in AutomationElement.RootElement.Find(
                            "User Promoted Notification Area").EnumChildButtons())
            {
                yield return button;
            }

            foreach (AutomationElement button in AutomationElement.RootElement.Find(
                          "System Promoted Notification Area").EnumChildButtons())
            {
                yield return button;
            }

            AutomationElement chevron = AutomationElement.RootElement.Find("Notification Chevron");
            if (chevron != null && chevron.InvokeButton())
            {
                foreach (AutomationElement button in AutomationElement.RootElement.Find(
                                   "Overflow Notification Area").EnumChildButtons())
                {
                    yield return button;
                }
            }
        }

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
