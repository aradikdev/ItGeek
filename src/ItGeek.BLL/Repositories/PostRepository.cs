﻿using ItGeek.DAL.Data;
using ItGeek.DAL.Entities;
using ItGeek.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ItGeek.BLL.Repositories;

public class PostRepository : GenericRepositoryAsync<Post>, IPostRepository
{

    private readonly AppDbContext _db;

    public PostRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<Post> GetBySlugAsync(string slug)
    {
        return await _db.Posts.Where(x => x.Slug == slug).Include(x=>x.PostContents).FirstAsync();
    }

	public async Task<List<Post>> ListByCategoryIdAsync(int categoryId)
	{

        List<PostCategory> postCategory = await _db.PostCategories
            .Where(x=>x.CategoryId == categoryId)
            .ToListAsync();

		List<Post> post = new List<Post>();

        foreach (var pc in postCategory)
        {
            post.Add(pc.Post);
		}

		return post;
	}
}
