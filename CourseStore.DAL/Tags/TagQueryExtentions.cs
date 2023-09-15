using CourseStore.Model.Tags.Dtos;
using CourseStore.Model.Tags.Entity;
using Microsoft.EntityFrameworkCore;

namespace CourseStore.DAL.Tags;
public static class TagqueryExtentions
{
    public static IQueryable<Tag> WhereOver(this IQueryable<Tag> tags , string tagName)
    {
        if (!string.IsNullOrEmpty(tagName))
            tags = tags.Where(t => t.TagName.Contains(tagName));
        return tags;
    }
    public static List<TagQr> ToTagQr(this IQueryable<Tag> tags)
    {
        return tags.Select(c => new TagQr
        {
            Id = c.Id,
            Name = c.TagName
        }).ToList();
    }
    public static async Task <List<TagQr>> ToTagQrAsync(this IQueryable<Tag> tags)
    {
        return await tags.Select(c=> new TagQr
        {
            Id= c.Id,
            Name = c.TagName
        }).ToListAsync();
    }
}

