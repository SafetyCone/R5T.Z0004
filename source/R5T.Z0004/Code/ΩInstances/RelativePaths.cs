using System;


namespace R5T.Z0004
{
	public class RelativePaths : IRelativePaths
	{
		#region Infrastructure

	    public static RelativePaths Instance { get; } = new();

	    private RelativePaths()
	    {
        }

	    #endregion
	}
}