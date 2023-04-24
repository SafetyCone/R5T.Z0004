using System;


namespace R5T.Z0004
{
	public class DirectoryPaths : IDirectoryPaths
	{
		#region Infrastructure

	    public static DirectoryPaths Instance { get; } = new();

	    private DirectoryPaths()
	    {
        }

	    #endregion
	}
}