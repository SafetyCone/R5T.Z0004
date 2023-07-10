using System;

using R5T.T0131;


namespace R5T.Z0004
{
    [ValuesMarker]
    public partial interface IPathologicalDirectoryNames : IValuesMarker
    {
        public static string WithTwoDots => "Directory..Name";
    }
}
