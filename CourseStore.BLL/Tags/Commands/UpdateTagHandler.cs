using CourseStore.BLL.Frameworks;
using CourseStore.DAL.DbContexts;
using CourseStore.Model.Framework;
using CourseStore.Model.Tags.Commands;
using CourseStore.Model.Tags.Entity;
using MediatR;

namespace CourseStore.BLL.Tags.Commands;

public class UpdateTagHandler : BaseApplicationServiceHandler<UpdateTag, Tag>
{
    public UpdateTagHandler(CourseStoreDbCoubtex courseStoreDbCoubtex) : base(courseStoreDbCoubtex)
    {
    }
    protected override async Task HandleRequest(UpdateTag request, CancellationToken cancellationToken)
    {
        Tag tag = _courseStoreDbCoubtex.Tags.SingleOrDefault(c => c.Id == request.Id);
        if (tag == null)
        {
            AddError($"تگ با شناسه {request.Id} یاقت نشد.");
        }
        else
        {
            tag.TagName = request.TagName;
            await _courseStoreDbCoubtex.SaveChangesAsync();
            AddResult(tag);
        }
    }
}


