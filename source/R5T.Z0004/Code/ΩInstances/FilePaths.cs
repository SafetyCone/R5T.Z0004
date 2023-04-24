using System;


namespace R5T.Z0004
{
	public class FilePaths : IFilePaths
	{
		#region Infrastructure

	    public static FilePaths Instance { get; } = new();

	    private FilePaths()
	    {
        }

	    #endregion
	}
}