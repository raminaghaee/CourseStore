﻿using CourseStore.DAL.DbContexts;
using CourseStore.Model.Framework;
using MediatR;
   
namespace CourseStore.BLL.Frameworks;
public abstract class BaseApplicationServiceHandler<TRequest, TResult> : IRequestHandler<TRequest, ApplicationServiceResponse<TResult>>
    where TRequest : IRequest<ApplicationServiceResponse<TResult>>
{
    protected readonly CourseStoreDbCoubtex _courseStoreDbCoubtex;
    private ApplicationServiceResponse<TResult> _response = new ApplicationServiceResponse<TResult> { };
    public BaseApplicationServiceHandler(CourseStoreDbCoubtex courseStoreDbCoubtex)
    {
        _courseStoreDbCoubtex = courseStoreDbCoubtex;
    }

    public async Task<ApplicationServiceResponse<TResult>> Handle(TRequest request, CancellationToken cancellationToken)
    {
        await HandleRequest(request, cancellationToken);
        return _response;
    }
    protected abstract Task HandleRequest(TRequest request, CancellationToken cancellationToken);

    public void AddError(string error)
    {
        _response.AddError(error);
    }
    public void AddResult(TResult result)=>
        _response.Result = result;
}
