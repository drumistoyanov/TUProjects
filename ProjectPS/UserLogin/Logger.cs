namespace UserLogin
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public static class Logger
    {
        public static readonly string WorkingDirectory = Environment.CurrentDirectory;
        public static readonly string TextFilePath = Directory.GetParent(WorkingDirectory).Parent.Parent.FullName + @"\log.txt";
        private static List<string> currentSessionActivities = new List<string>();

        public static void LogActivity(string activity)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now);
            sb.Append(" - ");
            sb.Append(LoginValidation.CurrentUserUsername);
            sb.Append(" - ");
            sb.Append(LoginValidation.CurrentUserRole);
            sb.Append(" - ");
            sb.Append(activity);
            sb.Append(Environment.NewLine);
            currentSessionActivities.Add(sb.ToString());
            File.AppendAllText(TextFilePath, sb.ToString());
        }

        public static string GetCurrentSessionActivities(string filter)
        {
            StringBuilder sb = new StringBuilder();

            var filteredActivities = (from activity in currentSessionActivities
                                      where activity.Contains(filter)
                                      select activity).ToList();

            foreach (var action in filteredActivities)
            {
                sb.Append(action);
            }

            if (sb.Length == 0)
            {
                sb.Append("No matching filter");
            }

            return sb.ToString();
        }
    }
}