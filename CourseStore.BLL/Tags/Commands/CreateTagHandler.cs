using CourseStore.BLL.Frameworks;
using CourseStore.DAL.DbContexts;
using CourseStore.Model.Framework;
using CourseStore.Model.Tags.Commands;
using CourseStore.Model.Tags.Entity;
using MediatR;

namespace CourseStore.BLL.Tags.Commands;
public class CreateTagHandler : BaseApplicationServiceHandler<CreateTag,Tag>
{
    public CreateTagHandler(CourseStoreDbCoubtex courseStoreDbCoubtex) : base(courseStoreDbCoubtex)
    {
    }
    protected override async Task HandleRequest(CreateTag request, CancellationToken cancellationToken)
    {
        Tag tag = new()
        {
            TagName = request.TagName
        };
        await _courseStoreDbCoubtex.Tags.AddAsync(tag);
        await _courseStoreDbCoubtex.SaveChangesAsync();

        AddResult(tag);
    }
}