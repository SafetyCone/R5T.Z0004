using System;

using R5T.T0131;


namespace R5T.Z0004
{
    [ValuesMarker]
    public interface IExample : IValuesMarker
    {
        public string GuidString => "9A19103F-16F7-4668-BE54-9A1E7A4F7556";
        public string LibraryName => "R5T.Example";
        public string ProjectName => "R5T.Example";
        public string RepositoryDescription => "An example repository.";
        public string RepositoryName => "R5T.Example";
    }
}