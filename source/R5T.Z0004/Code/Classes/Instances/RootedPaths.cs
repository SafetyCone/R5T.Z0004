using System;


namespace R5T.Z0004
{
	public class RootedPaths : IRootedPaths
	{
		#region Infrastructure

	    public static RootedPaths Instance { get; } = new();

	    private RootedPaths()
	    {
        }

	    #endregion
	}
}