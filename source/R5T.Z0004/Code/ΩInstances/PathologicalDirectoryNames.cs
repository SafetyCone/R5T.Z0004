using System;


namespace R5T.Z0004
{
    public class PathologicalDirectoryNames : IPathologicalDirectoryNames
    {
        #region Infrastructure

        public static IPathologicalDirectoryNames Instance { get; } = new PathologicalDirectoryNames();


        private PathologicalDirectoryNames()
        {
        }

        #endregion
    }
}
