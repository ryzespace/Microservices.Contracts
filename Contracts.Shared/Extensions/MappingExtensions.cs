using Mapster;
using Microsoft.Extensions.Logging;

namespace Contracts.Shared.Extensions;

/// <summary>
/// Provides extension methods for mapping objects using Mapster.
/// </summary>
/// <remarks>
/// Supports simple and TypeAdapter-based mappings, with optional logging.
/// Throws <see cref="ArgumentNullException"/> if the source is null.
/// </remarks>
public static class MappingExtensions
{
    /// <param name="source">The source object to map.</param>
    /// <typeparam name="TSource">Type of the source object.</typeparam>
    extension<TSource>(TSource source)
    {
        /// <summary>
        /// Maps the source object to the destination type using Mapster.
        /// </summary>
        /// <typeparam name="TDestination">Type of the destination object.</typeparam>
        /// <param name="logger">Optional <see cref="ILogger"/> for debug logging.</param>
        /// <returns>Mapped destination object.</returns>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="source"/> is null.</exception>
        public TDestination MapTo<TDestination>(ILogger? logger = null)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            var dest = source.Adapt<TDestination>();
            logger?.LogDebug("Mapped {SourceType} → {DestinationType}", typeof(TSource), typeof(TDestination));
            return dest;
        }

        /// <summary>
        /// Maps the source object to the destination type using Mapster TypeAdapter.
        /// Ensures full mapping of nested objects and collections.
        /// </summary>
        /// <typeparam name="TDestination">Type of the destination object.</typeparam>
        /// <param name="logger">Optional <see cref="ILogger"/> for debug logging.</param>
        /// <returns>Mapped destination object.</returns>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="source"/> is null.</exception>
        public TDestination MapToTypeAdapter<TDestination>(ILogger? logger = null)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            var destination = TypeAdapter.Adapt<TDestination>(source);
            logger?.LogDebug("Mapped with TypeAdapter {SourceType} → {DestinationType}", typeof(TSource), typeof(TDestination));
            return destination;
        }
    }
}
