using ItGeek.DAL.Entities;

namespace ItGeek.DAL.Interfaces;

public interface IPostContentRepository : IGenericRepositoryAsync<PostContent>
{
    //Task<PostContent> GetByPostIDAsync(int id);
}
