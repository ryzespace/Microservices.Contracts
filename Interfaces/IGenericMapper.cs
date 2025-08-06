namespace Microservices.Contracts.Interfaces;

/// <summary>
/// Defines a generic contract for mapping an input object of type <typeparamref name="TRequest"/> 
/// into a result object of type <typeparamref name="TResult"/>.
/// </summary>
/// <typeparam name="TRequest">The source type to map from (e.g., DTO, event, external message).</typeparam>
/// <typeparam name="TResult">The target type to map to (e.g., application command, domain model, integration event).</typeparam>
/// <remarks>
/// <para>This interface decouples transformation logic between layers or bounded contexts by:</para>
/// <list type="bullet">
///   <item><description>Encapsulating mapping logic away from business or transport layers.</description></item>
///   <item><description>Supporting polymorphic or conditional mappings via <see cref="CanMap"/>.</description></item>
///   <item><description>Promoting separation of concerns and testability in distributed or modular systems.</description></item>
/// </list>
/// </remarks>
public interface IGenericMapper<in TRequest, out TResult>
{
    /// <summary>
    /// Determines whether this mapper can handle mapping for the given request instance.
    /// </summary>
    /// <param name="request">The input object to evaluate.</param>
    /// <returns><c>true</c> if the mapper supports this request; otherwise, <c>false</c>.</returns>
    bool CanMap(TRequest request);

    /// <summary>
    /// Maps the specified input object to its corresponding output representation.
    /// </summary>
    /// <param name="request">The object to be mapped.</param>
    /// <returns>The mapped result of type <typeparamref name="TResult"/>.</returns>
    TResult Map(TRequest request);
}