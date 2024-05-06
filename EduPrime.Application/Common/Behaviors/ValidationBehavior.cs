using ErrorOr;
using FluentValidation;
using MediatR;

namespace EduPrime.Application.Common.Behaviors;

/// <summary>
/// Generic validation pipeline behavior
/// </summary>
/// <typeparam name="TRequest"></typeparam>
/// <typeparam name="TResponse"></typeparam>
public class ValidationBehavior<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
      where TRequest : IRequest<TResponse>
      where TResponse : IErrorOr
{

    private readonly IValidator<TRequest>? _validator;

    public ValidationBehavior(IValidator<TRequest> validator = null)
    {
        _validator = validator;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        if (_validator is null)
        {
            return await next();
        }

        var validationResult = await _validator.ValidateAsync(request, cancellationToken);

        if (validationResult.IsValid)
        {
            return await next();
        }

        // Convert all the errors to Error Validations
        var errors = validationResult.Errors
            .ConvertAll(error =>
                Error.Validation(
                  code: error.ErrorCode,
                  description: error.ErrorMessage));

        return (dynamic)errors;
    }
}
