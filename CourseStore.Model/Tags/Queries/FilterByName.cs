using CourseStore.Model.Framework;
using CourseStore.Model.Tags.Dtos;
using MediatR;
 
namespace CourseStore.Model.Tags.Queries;
public class FilterByName : IRequest<ApplicationServiceResponse<List<TagQr>>>
{
    //ورودی جهت جستجو
    public string? TagName{ get; set; }
}

