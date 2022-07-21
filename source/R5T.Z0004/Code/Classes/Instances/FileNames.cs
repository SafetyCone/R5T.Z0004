using System;


namespace R5T.Z0004
{
	public class FileNames : IFileNames
	{
		#region Infrastructure

	    public static FileNames Instance { get; } = new();

	    private FileNames()
	    {
        }

	    #endregion
	}
}