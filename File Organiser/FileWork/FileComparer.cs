using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Folder_Sorter.FileWork
{
    public class FileComparer : IComparer
    {
        private readonly int column;
        private readonly bool ascending;

        public FileComparer(int column, bool ascending)
        {
            this.column = column;
            this.ascending = ascending;
        }

        public int Compare(object? x, object? y)
        {
            if (x is not ListViewItem a ||
                y is not ListViewItem b ||
                a.Tag is not FileInfo fileA ||
                b.Tag is not FileInfo fileB)
                return 0;

            int result = column switch
            {
                0 => StringComparer.CurrentCultureIgnoreCase.Compare(fileA.Name, fileB.Name),

                1 => StringComparer.OrdinalIgnoreCase.Compare(fileA.Extension, fileB.Extension),

                2 => fileA.Length.CompareTo(fileB.Length),

                3 => fileA.CreationTime.CompareTo(fileB.CreationTime),

                4 => fileA.LastAccessTime.CompareTo(fileB.LastAccessTime),

                5 => StringComparer.CurrentCultureIgnoreCase.Compare(
                    a.SubItems[5].Text,
                    b.SubItems[5].Text
                ),

                _ => 0
            };

            return ascending ? result : -result;
        }
    }
}
