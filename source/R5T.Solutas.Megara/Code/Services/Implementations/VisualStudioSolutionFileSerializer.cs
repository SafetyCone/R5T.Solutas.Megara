using System;

using R5T.Cambridge.Types;
using R5T.Megara;
using R5T.Megara.Default;using R5T.T0064;


namespace R5T.Solutas.Megara
{[ServiceImplementationMarker]
    public class VisualStudioSolutionFileSerializer : FileSerializerBasedFileSerializer<SolutionFile>, IVisualStudioSolutionFileSerializer,IServiceImplementation
    {
        public VisualStudioSolutionFileSerializer(IFileSerializer<SolutionFile> fileSerializer)
            : base(fileSerializer)
        {
        }
    }
}
