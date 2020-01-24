using System;

using R5T.Cambridge.Types;
using R5T.Megara;
using R5T.Megara.Default;


namespace R5T.Solutas.Megara
{
    public class VisualStudioSolutionFileSerializer : FileSerializerBasedFileSerializer<SolutionFile>, IVisualStudioSolutionFileSerializer
    {
        public VisualStudioSolutionFileSerializer(IFileSerializer<SolutionFile> fileSerializer)
            : base(fileSerializer)
        {
        }
    }
}
