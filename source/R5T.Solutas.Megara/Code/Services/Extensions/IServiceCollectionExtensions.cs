using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Cambridge.Types;
using R5T.Dacia;
using R5T.Megara;


namespace R5T.Solutas.Megara
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileSerializer"/> implementation of <see cref="IVisualStudioSolutionFileSerializer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddMegaraVisualStudioSolutionFileSerializer(this IServiceCollection services,
            ServiceAction<IFileSerializer<SolutionFile>> addSolutionFileSerializer)
        {
            services
                .AddSingleton<IVisualStudioSolutionFileSerializer, VisualStudioSolutionFileSerializer>()
                .RunServiceAction(addSolutionFileSerializer)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileSerializer"/> implementation of <see cref="IVisualStudioSolutionFileSerializer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IVisualStudioSolutionFileSerializer> AddMegaraVisualStudioSolutionFileSerializerAction(this IServiceCollection services,
            ServiceAction<IFileSerializer<SolutionFile>> addSolutionFileSerializer)
        {
            var serviceAction = new ServiceAction<IVisualStudioSolutionFileSerializer>(() => services.AddMegaraVisualStudioSolutionFileSerializer(
                addSolutionFileSerializer));
            return serviceAction;
        }
    }
}
