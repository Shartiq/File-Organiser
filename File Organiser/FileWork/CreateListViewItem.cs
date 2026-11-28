namespace FileOrganiser.FileWork
{
    public class CreateListViewItem
    {
        public static ListViewItem? CreateDetailed(FileInfo file, int index, bool showHidden, bool showSystem)
        {
            bool hidden = file.Attributes.HasFlag(FileAttributes.Hidden);
            bool system = file.Attributes.HasFlag(FileAttributes.System);

            string attributes = GetAttributes(hidden, system);

            if (!IsVisible(hidden, system, showHidden, showSystem)) return null; 

            return new ListViewItem([
                    index.ToString(),
                    file.Name,
                    file.Extension,
                    FormatBytes.Format(file.Length),
                    file.CreationTime.ToString(),
                    file.LastAccessTime.ToString(),
                    attributes
            ])
            { Tag = file };
        }

        public static ListViewItem CreateCompact(FileInfo file, int index)
        {
            return new ListViewItem([
                    index.ToString(),
                    file.Name,
                    FormatBytes.Format(file.Length),
            ])
            { Tag = file };
        }

        private static string GetAttributes(bool hidden, bool system)
        {
            if (hidden && system) return "Hidden, System";
            else if (hidden) return "Hidden";
            else if (system) return "System";

            return "None";
        }

        private static bool IsVisible(bool hidden, bool system, bool showHidden, bool showSystem)
        {
            return (showHidden || !hidden) && (showSystem || !system);
        }
    }
}