﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Model.Framework;
public class ApplicationServiceResponse
{
    private readonly List<string> _errors =new();
    public bool IsSuccess =>!IsFeiler;
    public bool IsFeiler => _errors.Any();
    public void AddError (string errorMessage)
    {
        _errors.Add(errorMessage);
    }
    public IReadOnlyList<string> Errors => _errors;
}
public class ApplicationServiceResponse<TResult>: ApplicationServiceResponse
{
    public TResult Result { get; set; }
}

