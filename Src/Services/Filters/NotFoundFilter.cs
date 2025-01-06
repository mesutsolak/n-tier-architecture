namespace Services.Filters;

public class NotFoundFilter<T, TId>(IGenericRepository<T, TId> genericRepository) : Attribute, IAsyncActionFilter where T : class where TId : struct
{

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        #region Temp

        // action metot çalışmadan önce

        //await next();

        // action metot çalıştıktan sonra.

        #endregion

        var idValue = context.ActionArguments.TryGetValue("id", out var idAsObject) ? idAsObject : null;

        if (idAsObject is not TId id)
        {
            await next();
            return;
        }

        if (await genericRepository.AnyAsync(id))
        {
            await next();
            return;
        }

        var entityName = typeof(T).Name;

        var actionName = context.ActionDescriptor.RouteValues["action"];

        var result = ServiceResult.Fail($"data bulunamamıştır. ({entityName})({actionName})");
        context.Result = new NotFoundObjectResult(result);
    }
}
