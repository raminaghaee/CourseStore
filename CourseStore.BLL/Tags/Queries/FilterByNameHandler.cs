using CourseStore.BLL.Frameworks;
using CourseStore.DAL.DbContexts;
using CourseStore.DAL.Tags;
using CourseStore.Model.Tags.Dtos;
using CourseStore.Model.Tags.Queries;

namespace CourseStore.BLL.Tags.Queries;
public class FilterByNameHandler : BaseApplicationServiceHandler<FilterByName, List<TagQr>>
{
    public FilterByNameHandler(CourseStoreDbCoubtex courseStoreDbCoubtex) : base(courseStoreDbCoubtex)
    {
    }

    protected override async Task HandleRequest(FilterByName request, CancellationToken cancellationToken)
    {
        var result = await _courseStoreDbCoubtex.Tags.WhereOver(request.TagName).ToTagQrAsync();
        AddResult(result);
    }
}

