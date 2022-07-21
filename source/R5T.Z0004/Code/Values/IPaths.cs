using System;

using R5T.T0131;

using Glossary = R5T.Y0000.Glossary.ForPaths;


namespace R5T.Z0004
{
	[ValuesMarker]
	public partial interface IPaths : IValuesMarker
	{
		/// <summary>
		/// A <inheritdoc cref="Glossary.FileIndicated" path="/name"/> path.
		/// </summary>
		public string Path_001 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0004\source\R5T.Z0004\R5T.Z0004.csproj";

		/// <summary>
		/// A <inheritdoc cref="Glossary.DirectoryIndicated" path="/name"/> path.
		/// </summary>
		public string Path_002 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0004\source\R5T.Z0004\";
	}
}