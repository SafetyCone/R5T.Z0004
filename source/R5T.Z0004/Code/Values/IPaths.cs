using System;

using R5T.T0131;

using Glossary = R5T.Y0006.Glossary.ForPaths;


namespace R5T.Z0004
{
    /// <summary>
    /// OBSOLETE - See R5T.Z0066.
    /// </summary>
    [ValuesMarker]
	public partial interface IPaths : IValuesMarker
	{
		/// <summary>
		/// A <inheritdoc cref="Glossary.FileIndicated" path="/name"/>, <inheritdoc cref="Glossary.Windows" path="/name"/> path:
		/// C:\Temp\Projects\R5T.Z0004\R5T.Z0004.csproj
		/// </summary>
		public string N001 => @"C:\Temp\Projects\R5T.Z0004\R5T.Z0004.csproj";

		/// <summary>
		/// A <inheritdoc cref="Glossary.DirectoryIndicated" path="/name"/>, <inheritdoc cref="Glossary.Windows" path="/name"/> path:
		/// C:\Temp\Projects\R5T.Z0004\
		/// </summary>
		public string N002 => @"C:\Temp\Projects\R5T.Z0004\";

		/// <summary>
		/// A <inheritdoc cref="Glossary.FileIndicated" path="/name"/>, <inheritdoc cref="Glossary.NonWindows" path="/name"/> path:
		/// /tmp/Projects/R5T.Z0004/R5T.Z0004.csproj
		/// </summary>
		public string N003 => @"/tmp/Projects/R5T.Z0004/R5T.Z0004.csproj";

		/// <summary>
		/// A <inheritdoc cref="Glossary.DirectoryIndicated" path="/name"/>, <inheritdoc cref="Glossary.NonWindows" path="/name"/> path:
		/// /tmp/Projects/R5T.Z0004/
		/// </summary>
		public string N004 => @"/tmp/Projects/R5T.Z0004/";

		public string N005 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0020\source\R5T.F0020\R5T.F0020.csproj";
		/// <summary>
		/// A pathological directory-indcated file path.
		/// </summary>
		public string N005_DirectoryIndicated => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0020\source\R5T.F0020\R5T.F0020.csproj\";
		public string N006 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0132\source\R5T.T0132\R5T.T0132.csproj";
		public string N007 => @"..\..\..\R5T.T0132\source\R5T.T0132\R5T.T0132.csproj";

		/// <summary>
		/// The parent directory path of <see cref="N005"/>.
		/// </summary>
		public string N008 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0020\source\R5T.F0020\";

		/// <summary>
		/// A pathological path:
		/// &lt;
		/// </summary>
		public string N009 => @"<";

		/// <summary>
		/// The base Windows C: drive path.
		/// </summary>
		public string N010 => @"C:\";

		/// <summary>
		/// A pathological path with an invalid file name character in one of its path parts.
		/// </summary>
		public string N011 => @"C:\Temp\Proje<ts\R5T.Z0004\";

		/// <summary>
		/// A valid path with a folder name and file name that start with two dots.
		/// </summary>
		public string N012 => @"C:\Temp\..Folder\..File.txt";

		/// <summary>
		/// An invalid path containing a directory name ending with the current directory name.
		/// </summary>
		public string N013 => @"C:\Temp\Folder.\File.txt";

		/// <summary>
		/// An invalid path containing a file name ending with the parent directory name.
		/// </summary>
		public string N014 => @"C:\Temp\Folder\File..";
	}
}